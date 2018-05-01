namespace GameOfLife
{
  partial class GameOfLifeBoard
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLifeBoard));
      this.drawablePictureBox = new DrawablePicturebox.DrawablePictureBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.startButton = new System.Windows.Forms.ToolStripButton();
      this.clearButton = new System.Windows.Forms.ToolStripButton();
      this.optionsButton = new System.Windows.Forms.ToolStripButton();
      this.createShapeButton = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // drawablePictureBox
      // 
      this.drawablePictureBox.AllowDrawing = true;
      this.drawablePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.drawablePictureBox.BrushColor = System.Drawing.Color.Black;
      this.drawablePictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
      this.drawablePictureBox.GridLines = true;
      this.drawablePictureBox.InverseBrushColor = System.Drawing.Color.White;
      this.drawablePictureBox.Location = new System.Drawing.Point(0, 25);
      this.drawablePictureBox.Margin = new System.Windows.Forms.Padding(0);
      this.drawablePictureBox.Name = "drawablePictureBox";
      this.drawablePictureBox.Size = new System.Drawing.Size(457, 340);
      this.drawablePictureBox.TabIndex = 0;
      this.drawablePictureBox.ZoomLevel = 8F;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.clearButton,
            this.optionsButton,
            this.createShapeButton});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(457, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // startButton
      // 
      this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(35, 22);
      this.startButton.Text = "Start";
      this.startButton.Click += new System.EventHandler(this.StartButtonClick);
      // 
      // clearButton
      // 
      this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(38, 22);
      this.clearButton.Text = "Clear";
      this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
      // 
      // optionsButton
      // 
      this.optionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.optionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.optionsButton.Name = "optionsButton";
      this.optionsButton.Size = new System.Drawing.Size(53, 22);
      this.optionsButton.Text = "Options";
      this.optionsButton.Click += new System.EventHandler(this.OptionsButtonClick);
      // 
      // createShapeButton
      // 
      this.createShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.createShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("createShapeButton.Image")));
      this.createShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.createShapeButton.Name = "createShapeButton";
      this.createShapeButton.Size = new System.Drawing.Size(80, 22);
      this.createShapeButton.Text = "Create Shape";
      this.createShapeButton.Click += new System.EventHandler(this.CreateShapeButtonClick);
      // 
      // GameOfLifeBoard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(457, 365);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.drawablePictureBox);
      this.Name = "GameOfLifeBoard";
      this.ShowIcon = false;
      this.Text = "Game of Life";
      this.Load += new System.EventHandler(this.GameOfLifeBoard_Load);
      this.Resize += new System.EventHandler(this.GameOfLifeBoardResize);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DrawablePicturebox.DrawablePictureBox drawablePictureBox;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton startButton;
    private System.Windows.Forms.ToolStripButton clearButton;
    private System.Windows.Forms.ToolStripButton optionsButton;
    private System.Windows.Forms.ToolStripButton createShapeButton;
  }
}

