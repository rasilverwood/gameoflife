namespace GameOfLife
{
  partial class OptionsDialog
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
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.underpopulationControl = new System.Windows.Forms.NumericUpDown();
      this.overpopulationControl = new System.Windows.Forms.NumericUpDown();
      this.reproductionControl = new System.Windows.Forms.NumericUpDown();
      this.okButton = new System.Windows.Forms.Button();
      this.wrapButton = new System.Windows.Forms.RadioButton();
      this.stopButton = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.underpopulationControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.overpopulationControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.reproductionControl)).BeginInit();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(288, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Any live cell with fewer than                     live neighbors dies";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(11, 45);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(288, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Any live cell with more than                      live neighbors dies";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 80);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(301, 26);
      this.label5.TabIndex = 4;
      this.label5.Text = "Any dead cell with exactly                      live neighbor becomes\r\n a live ce" +
    "ll";
      // 
      // underpopulationControl
      // 
      this.underpopulationControl.Location = new System.Drawing.Point(148, 11);
      this.underpopulationControl.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.underpopulationControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.underpopulationControl.Name = "underpopulationControl";
      this.underpopulationControl.Size = new System.Drawing.Size(55, 20);
      this.underpopulationControl.TabIndex = 5;
      this.underpopulationControl.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // overpopulationControl
      // 
      this.overpopulationControl.Location = new System.Drawing.Point(148, 43);
      this.overpopulationControl.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.overpopulationControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.overpopulationControl.Name = "overpopulationControl";
      this.overpopulationControl.Size = new System.Drawing.Size(55, 20);
      this.overpopulationControl.TabIndex = 6;
      this.overpopulationControl.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // reproductionControl
      // 
      this.reproductionControl.Location = new System.Drawing.Point(141, 78);
      this.reproductionControl.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.reproductionControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.reproductionControl.Name = "reproductionControl";
      this.reproductionControl.Size = new System.Drawing.Size(55, 20);
      this.reproductionControl.TabIndex = 7;
      this.reproductionControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(128, 184);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 10;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // wrapButton
      // 
      this.wrapButton.AutoSize = true;
      this.wrapButton.Location = new System.Drawing.Point(14, 128);
      this.wrapButton.Name = "wrapButton";
      this.wrapButton.Size = new System.Drawing.Size(83, 17);
      this.wrapButton.TabIndex = 11;
      this.wrapButton.TabStop = true;
      this.wrapButton.Text = "Wrap edges";
      this.wrapButton.UseVisualStyleBackColor = true;
      // 
      // stopButton
      // 
      this.stopButton.AutoSize = true;
      this.stopButton.Location = new System.Drawing.Point(14, 151);
      this.stopButton.Name = "stopButton";
      this.stopButton.Size = new System.Drawing.Size(91, 17);
      this.stopButton.TabIndex = 12;
      this.stopButton.TabStop = true;
      this.stopButton.Text = "Stop at edges";
      this.stopButton.UseVisualStyleBackColor = true;
      // 
      // OptionsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(324, 217);
      this.Controls.Add(this.stopButton);
      this.Controls.Add(this.wrapButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.reproductionControl);
      this.Controls.Add(this.overpopulationControl);
      this.Controls.Add(this.underpopulationControl);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Name = "OptionsDialog";
      this.ShowIcon = false;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.OptionsDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.underpopulationControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.overpopulationControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.reproductionControl)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown underpopulationControl;
    private System.Windows.Forms.NumericUpDown overpopulationControl;
    private System.Windows.Forms.NumericUpDown reproductionControl;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.RadioButton wrapButton;
    private System.Windows.Forms.RadioButton stopButton;
  }
}