using System.Linq;

namespace GameOfLife
{
  public static class GridHelper
  {
    public static Options Options { get; set; }

    public static bool ShouldLive(this bool[,] grid, int x, int y)
    {
      var liveNeighbors = grid.GetLiveNeighbors(x, y);

      if (grid[x, y]) return liveNeighbors >= Options.Underpopulation && liveNeighbors <= Options.Overpopulation;

      return liveNeighbors == Options.Reproduction;
    }

    public static int GetLiveNeighbors(this bool[,] grid, int x, int y)
    {
      return grid.GetDiagonalLiveNeighbors(x, y) + grid.GetDirectNeighbors(x, y);
    }

    public static int GetDiagonalLiveNeighbors(this bool[,] grid, int x, int y)
    {
      var live = 0;
      
      if (grid.IsTopLeftAlive(x, y)) live++;
      if (grid.IsTopRightAlive(x, y)) live++;
      if (grid.IsBottomLeftAlive(x, y)) live++;
      if (grid.IsBottomRightAlive(x, y)) live++;

      return live;
    }

    public static int GetDirectNeighbors(this bool[,] grid, int x, int y)
    {
      var live = 0;

      if (grid.IsAboveAlive(x, y)) live++;
      if (grid.IsBelowAlive(x, y)) live++;
      if (grid.IsLeftAlive(x, y)) live++;
      if (grid.IsRightAlive(x, y)) live++;

      return live;
    }

    public static bool[,] GetClearedGrid(this bool[,] grid)
    {
      return new bool[grid.GetLength(0), grid.GetLength(1)];
    }

    public static int GetXBound()
    {
      return Options.Length - 1;
    }

    public static int GetYBound()
    {
      return Options.Height - 1;
    }

    public static bool Equal(this bool[,] grid, bool[,] newGrid)
    {
      var equal = grid.Rank == newGrid.Rank &&
                  Enumerable.Range(0, grid.Rank).All(x => grid.GetLength(x) == newGrid.GetLength(x)) &&
                  grid.Cast<bool>().SequenceEqual(newGrid.Cast<bool>());

      return equal;
    }

    private static bool IsTopLeftAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && (x == 0 || y == 0)) return false;

      if (x == 0) x = Options.Length;
      if (y == 0) y = Options.Height;
      
      return grid[x - 1, y - 1];
    }

    private static bool IsTopRightAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && (x == GetXBound() || y == 0)) return false;

      if (x == Options.XMax) x = -1;
      if (y == 0) y = Options.Height;

      return grid[x + 1, y - 1];
    }

    private static bool IsBottomLeftAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && (x == 0 || y == GetYBound())) return false;

      if (x == 0) x = Options.Length;
      if (y == Options.YMax) y = -1;

      return grid[x - 1, y + 1];
    }

    private static bool IsBottomRightAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && (x == GetXBound() || y == GetYBound())) return false;

      if (x == Options.XMax) x = -1;
      if (y == Options.YMax) y = -1;

      return grid[x + 1, y + 1];
    }

    private static bool IsAboveAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && y == 0) return false;

      if (y == 0) y = Options.Height;

      return grid[x, y - 1];
    }

    private static bool IsBelowAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && y == GetYBound()) return false;

      if (y == Options.YMax) y = -1;

      return grid[x, y + 1];
    }

    private static bool IsLeftAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && x == 0) return false;

      if (x == 0) x = Options.Length;

      return grid[x - 1, y];
    }

    private static bool IsRightAlive(this bool[,] grid, int x, int y)
    {
      if (!ShouldWrap() && x == GetXBound()) return false;

      if (x == Options.XMax) x = -1;

      return grid[x + 1, y];
    }

    private static bool ShouldWrap()
    {
      return Options.EdgeOption == EdgeOption.Wrap;
    }

    public static bool[,] CreatePulsar(this bool[,] grid, int startX, int startY)
    {
      grid[startX + 1, startY + 5] = true;
      grid[startX + 2, startY + 5] = true;
      grid[startX + 3, startY + 5] = true;
      grid[startX + 3, startY + 6] = true;

      grid[startX + 5, startY + 1] = true;
      grid[startX + 5, startY + 2] = true;
      grid[startX + 5, startY + 3] = true;
      grid[startX + 6, startY + 3] = true;

      grid[startX + 5, startY + 6] = true;
      grid[startX + 5, startY + 7] = true;
      grid[startX + 6, startY + 7] = true;
      grid[startX + 6, startY + 5] = true;
      grid[startX + 7, startY + 5] = true;
      grid[startX + 7, startY + 6] = true;

      for (var x = 0; x < 8 + startX; x++)
      {
        for (var y = 0; y < 8 + startY; y++)
        {
          if (grid[x, y])
          {
            grid[2 * startX + 16 - x, y] = true;
            grid[x, 2 * startY + 16 - y ] = true;
            grid[2 * startX + 16 - x, 2 * startY + 16 - y] = true;
          }
        }
      }

      return grid;
    }

    public static bool[,] CreateGlider(this bool[,] grid, int startX, int startY)
    {
      grid[startX + 1, startY + 3] = true;
      grid[startX + 2, startY + 3] = true;
      grid[startX + 3, startY + 3] = true;
      grid[startX + 3, startY + 2] = true;
      grid[startX + 2, startY + 1] = true;

      return grid;
    }

    public static bool[,] CreatePentomino(this bool[,] grid, int startX, int startY)
    {
      grid[startX + 2, startY + 2] = true;
      grid[startX + 2, startY + 1] = true;
      grid[startX + 1, startY + 2] = true;
      grid[startX + 3, startY + 1] = true;
      grid[startX + 2, startY + 3] = true;

      return grid;
    }
  }
}
