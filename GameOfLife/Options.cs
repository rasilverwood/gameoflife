namespace GameOfLife
{
  public class Options
  {
    public EdgeOption EdgeOption { get; set; }
    public int Underpopulation { get; set; }
    public int Overpopulation { get; set; }
    public int Reproduction { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int XMax => Length - 1;
    public int YMax => Height - 1;

    public Options()
    {
      EdgeOption = EdgeOption.Stop;
      Underpopulation = 2;
      Overpopulation = 3;
      Reproduction = 3;
    }
  }

  public enum EdgeOption
  {
    Wrap,
    Stop
  }
}
