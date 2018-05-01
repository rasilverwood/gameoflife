using System;
using System.Threading;
using System.Windows.Forms;
using FastImageHelper;

namespace GameOfLife
{
  public partial class GameOfLifeBoard : Form
  {
    private bool _running;
    
    public GameOfLifeBoard()
    {
      InitializeComponent();
      SetDefaults();
    }

    private void SetDefaults()
    {
      var grid = drawablePictureBox.Image.ToBools().GetClearedGrid();

      drawablePictureBox.ZoomLevel = 10;
      drawablePictureBox.RenewImage(grid.ToBitmap());
      drawablePictureBox.Refresh();

      GridHelper.Options = new Options();
    }

    private void StartButtonClick(object sender, EventArgs e)
    {
      ToggleStartStopMode(!_running);

      if (_running)
      {
        var thread = new Thread(Go);
        thread.Start();
      }
    }

    private void ClearView()
    {
      var grid = drawablePictureBox.Image.ToBools().GetClearedGrid();
      drawablePictureBox.RenewImage(grid.ToBitmap());
      drawablePictureBox.AllowDrawing = true;
    }

    private void Go()
    {
      var grid = drawablePictureBox.Image.ToBools();
      var newGrid = grid.GetClearedGrid();

      GridHelper.Options.Length = grid.GetLength(0);
      GridHelper.Options.Height = grid.GetLength(1);

      while (!grid.Equal(newGrid) && _running)
      {
        grid = drawablePictureBox.Image.ToBools();
        newGrid = Generate(grid);
        UpdatePictureBox(newGrid);
      }

      ToggleStartStopMode(false);
    }

    private void UpdatePictureBox(bool[,] grid)
    {
      if (drawablePictureBox.InvokeRequired)
      {
        Invoke(new Action(() => UpdatePictureBox(grid)));
      }
      else
      {
        drawablePictureBox.RenewImage(grid.ToBitmap());
        drawablePictureBox.Refresh();
      }
    }

    private static bool[,] Generate(bool[,] grid)
    {
      var newGrid = grid.GetClearedGrid();

      for (var x = 0; x < GridHelper.Options.Length; x++)
      {
        for (var y = 0; y < GridHelper.Options.Height; y++)
        {
          newGrid[x, y] = grid.ShouldLive(x, y);
        }
      }

      return newGrid;
    }

    private void ToggleStartStopMode(bool running)
    {
      _running = running;
      UpdateControls();
    }

    private void UpdateControls()
    {
      if (InvokeRequired) Invoke(new Action(UpdateControls));
      else
      {
        drawablePictureBox.AllowDrawing = !_running;
        startButton.Text = _running ? "Stop" : "Start";
        clearButton.Enabled = !_running;
        optionsButton.Enabled = !_running;
        createShapeButton.Enabled = !_running;
      }
    }

    private void OptionsButtonClick(object sender, EventArgs e)
    {
      using (var dialog = new OptionsDialog())
      {
        dialog.SetValues(GridHelper.Options);
        var result = dialog.ShowDialog();
        if (result == DialogResult.Cancel) return;
        GridHelper.Options = dialog.CreateOptions();
      }
    }

    private void GameOfLifeBoard_Resize(object sender, EventArgs e)
    {
      var grid = drawablePictureBox.Image.ToBools();

      GridHelper.Options.Length = grid.GetLength(0);
      GridHelper.Options.Height = grid.GetLength(1);
    }

    private void GameOfLifeBoard_Load(object sender, EventArgs e)
    {
      CenterToScreen();
    }

    private void DisplayShape(Shape shape, int x, int y)
    {
      var grid = drawablePictureBox.Image.ToBools();

      if(shape == Shape.Pulsar) grid = grid.CreatePulsar(x, y);
      else if (shape == Shape.Glider) grid = grid.CreateGlider(x, y);
      else if (shape == Shape.Pentomino) grid = grid.CreatePentomino(x, y);

      UpdatePictureBox(grid);
    }

    private void ClearButtonClick(object sender, EventArgs e)
    {
      ClearView();
    }

    private void createShapeButton_Click(object sender, EventArgs e)
    {
      var grid = drawablePictureBox.Image.ToBools().GetClearedGrid();

      GridHelper.Options.Length = grid.GetLength(0);
      GridHelper.Options.Height = grid.GetLength(1);

      using (var dialog = new AddShapeDialog(GridHelper.Options.Length, GridHelper.Options.Height))
      {
        var result = dialog.ShowDialog();
        if (result == DialogResult.Cancel) return;
        DisplayShape(dialog.Shape, dialog.XValue, dialog.YValue);
      }
    }
  }
}
