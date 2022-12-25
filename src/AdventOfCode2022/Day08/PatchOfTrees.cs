namespace AdventOfCode2022.Day08;

public class PatchOfTrees
{
    public int[][] TreesByRow { get; }
    public int[][] TreesByCol { get; }
    public int Height { get; }
    public int Width { get; }
    public HashSet<(int Row, int Height)> Visible { get; }

    public PatchOfTrees(string input)
    {
        var trees = input.SplitLines().ToArray();
        Height = trees.Length;
        Width = trees[0].Length;

        TreesByRow = new int[Height][];
        for (var height = 0; height < Height; height++)
        {
            TreesByRow[height] = new int[Width];
        }

        TreesByCol = new int[Width][];
        for (var width = 0; width < Width; width++)
        {
            TreesByCol[width] = new int[Height];
        }

        for (var row = 0; row < Height; row++)
        {
            for (var col = 0; col < Width; col++)
            {
                TreesByRow[row][col] = TreesByCol[col][row] = trees[row][col] - '0';
            }
        }

        Visible = new();
        for (var row = 0; row < Height; row++)
        {
            for (var col = 0; col < Width; col++)
            {
                if (CanBeSeen(row, col))
                    Visible.Add((row, col));
            }
        }
    }

    private bool CanBeSeen(int row, int col)
    {
        if (row == 0 || row == Height - 1 || col == 0 || col == Width - 1)
        {
            return true;
        }

        var val = TreesByRow[row][col];
        if (Up(row, col).Max() < val ||
            Down(row, col).Max() < val ||
            Left(row, col).Max() < val ||
            Right(row, col).Max() < val)
            {
                return true;
            }

        return false;
    }

    public IEnumerable<int> Up(int row, int col) => TreesByCol[col][0..row];
    public IEnumerable<int> Down(int row, int col) => TreesByCol[col][(row+1)..];
    public IEnumerable<int> Left(int row, int col) => TreesByRow[row][0..col];
    public IEnumerable<int> Right(int row, int col) => TreesByRow[row][(col+1)..];
}