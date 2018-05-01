using System;
using System.Windows.Forms;

namespace GameOfLife
{
  public partial class OptionsDialog : Form
  {
    public OptionsDialog()
    {
      InitializeComponent();
    }

    public void SetValues(Options options)
    {
      wrapButton.Checked = options.EdgeOption == EdgeOption.Wrap;
      stopButton.Checked = options.EdgeOption == EdgeOption.Stop;
      underpopulationControl.Value = options.Underpopulation;
      overpopulationControl.Value = options.Overpopulation;
      reproductionControl.Value = options.Reproduction;
    }

    public Options CreateOptions()
    {
      return new Options
      {
        EdgeOption = wrapButton.Checked ? EdgeOption.Wrap : EdgeOption.Stop,
        Underpopulation = Convert.ToInt16(underpopulationControl.Value),
        Overpopulation = Convert.ToInt16(overpopulationControl.Value),
        Reproduction = Convert.ToInt16(reproductionControl.Value),
      };
    }

    private void okButton_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      Close();
    }

    private void OptionsDialog_Load(object sender, EventArgs e)
    {
      CenterToScreen();
    }
  }
}
