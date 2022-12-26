namespace AdventOfCode2022.Day08;

public class PatchOfTrees
{
    public byte[][] TreesByRow { get; }
    public byte[][] TreesByCol { get; }
    public int Height { get; }
    public int Width { get; }
    public int Visible { get; }
    public int HighestScenicScore { get; }

    public PatchOfTrees(string input)
    {
        var trees = input.SplitLines().ToArray();
        Height = trees.Length;
        Width = trees[0].Length;

        TreesByRow = new byte[Height][];
        for (var height = 0; height < Height; height++)
        {
            TreesByRow[height] = new byte[Width];
        }

        TreesByCol = new byte[Width][];
        for (var width = 0; width < Width; width++)
        {
            TreesByCol[width] = new byte[Height];
        }

        for (var row = 0; row < Height; row++)
        {
            for (var col = 0; col < Width; col++)
            {
                TreesByRow[row][col] = TreesByCol[col][row] = (byte)(trees[row][col] - '0');
            }
        }

        for (var row = 0; row < Height; row++)
        {
            for (var col = 0; col < Width; col++)
            {
                if (CanBeSeen(row, col))
                    Visible++;
            }
        }

        for (var row = 0; row < Height; row++)
        {
            for (var col = 0; col < Width; col++)
            {
                var score = ScenicScore(row, col);
                if (score > HighestScenicScore)
                    HighestScenicScore = score;
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
        return Up(row, col).Max() < val ||
               Down(row, col).Max() < val ||
               Left(row, col).Max() < val ||
               Right(row, col).Max() < val;
    }

    private int ScenicScore(int row, int col)
    {
        var val = TreesByRow[row][col];
        return CanSeeHowMany(Up(row, col)) *
               CanSeeHowMany(Down(row, col)) *
               CanSeeHowMany(Left(row, col)) *
               CanSeeHowMany(Right(row, col));

        int CanSeeHowMany(byte[] trees)
        {
            for (var k = 0; k < trees.Length; ++k)
            {
                if (trees[k] >= val)
                {
                    return k + 1;
                }
            }
            return trees.Length;
        }
    }

    public byte[] Up(int row, int col) => TreesByCol[col][..row].Reverse().ToArray();
    public byte[] Down(int row, int col) => TreesByCol[col][(row+1)..];
    public byte[] Left(int row, int col) => TreesByRow[row][..col].Reverse().ToArray();
    public byte[] Right(int row, int col) => TreesByRow[row][(col+1)..];
}