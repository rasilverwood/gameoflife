using System;
using System.Windows.Forms;

namespace GameOfLife
{
  public partial class AddShapeDialog : Form
  {
    public int XValue => Convert.ToInt16(xValue.Value);
    public int YValue => Convert.ToInt16(yValue.Value);

    private readonly int _xSize;
    private readonly int _ySize;

    public Shape Shape
    {
      get
      {
        if (gliderButton.Checked) return Shape.Glider;
        if (pulsarButton.Checked) return Shape.Pulsar;
        return Shape.Pentomino;
      }
    }

    public AddShapeDialog(int x, int y)
    {
      InitializeComponent();
      _xSize = x;
      _ySize = y;
      gliderButton.Checked = true;

      xValue.Value = 0;
      yValue.Value = 0;
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void AddShapeDialog_Load(object sender, EventArgs e)
    {
      CenterToScreen();
    }

    private void gliderButton_CheckedChanged(object sender, EventArgs e)
    {
      xValue.Maximum = Math.Max(0, _xSize - 4);
      yValue.Maximum = Math.Max(0, _ySize - 4);

      ValidateControls();
    }

    private void pulsarButton_CheckedChanged(object sender, EventArgs e)
    {
      xValue.Maximum = Math.Max(0, _xSize - 16);
      yValue.Maximum = Math.Max(0, _ySize - 16);

      ValidateControls();
    }

    private void pentominoButton_CheckedChanged(object sender, EventArgs e)
    {
      xValue.Maximum = Math.Max(0, _xSize - 4);
      yValue.Maximum = Math.Max(0, _ySize - 4);

      ValidateControls();
    }

    private void ValidateControls()
    {
      xValue.Validate();
      yValue.Validate();
    }
  }

  public enum Shape
  {
    Glider,
    Pulsar,
    Pentomino
  }
}
