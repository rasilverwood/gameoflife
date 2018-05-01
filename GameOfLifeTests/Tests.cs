using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTests
{
  [TestFixture]
  public class Tests
  {
    [SetUp]
    public static void Setup()
    {
      var options = new Options()
      {
        Length = 10,
        Height = 10
      };

      GridHelper.Options = options;
    }

    [Test]
    public static void TestLiveWithNoNeighbors()
    {
      var grid = GetGrid();

      Assert.That(grid.ShouldLive(2, 2), Is.False);
    }

    [Test]
    public static void TestLiveWithOneNeighbor()
    {
      var grid = GetGrid();
      grid[1, 2] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.False);
    }

    [Test]
    public static void TestLiveWithTwoNeighbors()
    {
      var grid = GetGrid();
      grid[1, 2] = true;
      grid[3, 2] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.True);
    }

    [Test]
    public static void TestLiveWithThreeNeighbors()
    {
      var grid = GetGrid();
      grid[1, 2] = true;
      grid[3, 2] = true;
      grid[1, 1] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.True);
    }

    [Test]
    public static void TestLiveWithFourNeighbors()
    {
      var grid = GetGrid();
      grid[1, 2] = true;
      grid[3, 2] = true;
      grid[1, 1] = true;
      grid[3, 3] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.False);
    }

    [Test]
    public static void TestDeadWith2Neighbors()
    {
      var grid = new bool[10, 10];
      grid[1, 2] = true;
      grid[3, 2] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.False);
    }

    [Test]
    public static void TestDeadWith3Neighbors()
    {
      var grid = new bool[10, 10];
      grid[1, 2] = true;
      grid[3, 2] = true;
      grid[1, 1] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.True);
    }

    [Test]
    public static void TestDeadWith4Neighbors()
    {
      var grid = new bool[10, 10];
      grid[1, 2] = true;
      grid[3, 2] = true;
      grid[1, 1] = true;
      grid[3, 3] = true;

      Assert.That(grid.ShouldLive(2, 2), Is.False);
    }

    [Test]
    public static void TestTopLeftDiagonal()
    {
      var grid = GetGrid();
      grid[1, 1] = true;

      Assert.That(grid.GetDiagonalLiveNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestTopRightDiagonal()
    {
      var grid = GetGrid();
      grid[3, 1] = true;

      Assert.That(grid.GetDiagonalLiveNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestBottomLeftDiagonal()
    {
      var grid = GetGrid();
      grid[1, 3] = true;

      Assert.That(grid.GetDiagonalLiveNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestBottomRightDiagonal()
    {
      var grid = GetGrid();
      grid[3, 3] = true;

      Assert.That(grid.GetDiagonalLiveNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestAbove()
    {
      var grid = GetGrid();
      grid[2, 1] = true;

      Assert.That(grid.GetDirectNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestBelow()
    {
      var grid = GetGrid();
      grid[2, 3] = true;

      Assert.That(grid.GetDirectNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestRight()
    {
      var grid = GetGrid();
      grid[1, 2] = true;

      Assert.That(grid.GetDirectNeighbors(2, 2) == 1);
    }

    [Test]
    public static void TestLeft()
    {
      var grid = GetGrid();
      grid[3, 2] = true;

      Assert.That(grid.GetDirectNeighbors(2, 2) == 1);
    }


    private static bool[,] GetGrid()
    {
      var grid = new bool[10, 10];
      grid[2, 2] = true;

      return grid;
    }
  }
}
