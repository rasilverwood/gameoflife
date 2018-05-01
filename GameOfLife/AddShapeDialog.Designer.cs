namespace GameOfLife
{
  partial class AddShapeDialog
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
      this.gliderButton = new System.Windows.Forms.RadioButton();
      this.pulsarButton = new System.Windows.Forms.RadioButton();
      this.pentominoButton = new System.Windows.Forms.RadioButton();
      this.okButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.xValue = new System.Windows.Forms.NumericUpDown();
      this.yValue = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.xValue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yValue)).BeginInit();
      this.SuspendLayout();
      // 
      // gliderButton
      // 
      this.gliderButton.AutoSize = true;
      this.gliderButton.Location = new System.Drawing.Point(12, 12);
      this.gliderButton.Name = "gliderButton";
      this.gliderButton.Size = new System.Drawing.Size(74, 17);
      this.gliderButton.TabIndex = 0;
      this.gliderButton.TabStop = true;
      this.gliderButton.Text = "The Glider";
      this.gliderButton.UseVisualStyleBackColor = true;
      this.gliderButton.CheckedChanged += new System.EventHandler(this.gliderButton_CheckedChanged);
      // 
      // pulsarButton
      // 
      this.pulsarButton.AutoSize = true;
      this.pulsarButton.Location = new System.Drawing.Point(12, 35);
      this.pulsarButton.Name = "pulsarButton";
      this.pulsarButton.Size = new System.Drawing.Size(76, 17);
      this.pulsarButton.TabIndex = 1;
      this.pulsarButton.TabStop = true;
      this.pulsarButton.Text = "The Pulsar";
      this.pulsarButton.UseVisualStyleBackColor = true;
      this.pulsarButton.CheckedChanged += new System.EventHandler(this.pulsarButton_CheckedChanged);
      // 
      // pentominoButton
      // 
      this.pentominoButton.AutoSize = true;
      this.pentominoButton.Location = new System.Drawing.Point(12, 58);
      this.pentominoButton.Name = "pentominoButton";
      this.pentominoButton.Size = new System.Drawing.Size(111, 17);
      this.pentominoButton.TabIndex = 2;
      this.pentominoButton.TabStop = true;
      this.pentominoButton.Text = "The R- Pentomino";
      this.pentominoButton.UseVisualStyleBackColor = true;
      this.pentominoButton.CheckedChanged += new System.EventHandler(this.pentominoButton_CheckedChanged);
      // 
      // okButton
      // 
      this.okButton.Location = new System.Drawing.Point(80, 154);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 3;
      this.okButton.Text = "OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Starting X:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 113);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Starting Y:";
      // 
      // xValue
      // 
      this.xValue.Location = new System.Drawing.Point(71, 88);
      this.xValue.Name = "xValue";
      this.xValue.Size = new System.Drawing.Size(57, 20);
      this.xValue.TabIndex = 6;
      // 
      // yValue
      // 
      this.yValue.Location = new System.Drawing.Point(71, 111);
      this.yValue.Name = "yValue";
      this.yValue.Size = new System.Drawing.Size(57, 20);
      this.yValue.TabIndex = 7;
      // 
      // AddShapeDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(235, 189);
      this.Controls.Add(this.yValue);
      this.Controls.Add(this.xValue);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.pentominoButton);
      this.Controls.Add(this.pulsarButton);
      this.Controls.Add(this.gliderButton);
      this.Name = "AddShapeDialog";
      this.ShowIcon = false;
      this.Text = "Add Pattern";
      this.Load += new System.EventHandler(this.AddShapeDialog_Load);
      ((System.ComponentModel.ISupportInitialize)(this.xValue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yValue)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton gliderButton;
    private System.Windows.Forms.RadioButton pulsarButton;
    private System.Windows.Forms.RadioButton pentominoButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown xValue;
    private System.Windows.Forms.NumericUpDown yValue;
  }
}