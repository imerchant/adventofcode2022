using AdventOfCode2022.Day08;

namespace AdventOfCode2022.Tests;

public class Day08Solutions
{
    [Fact]
    public void Puzzle1And2_CountVisibleTrees_AndFindHighestScenicScore()
    {
        var trees = new PatchOfTrees(Input.Day08);

        trees.Visible.Should().Be(1672);
        trees.HighestScenicScore.Should().Be(327180);
    }

    private const string Example =
@"30373
25512
65332
33549
35390";

    [Fact]
    public void Example_CreatesPatchCorrectly()
    {
        var trees = new PatchOfTrees(Example);

        trees.Height.Should().Be(5);
        trees.Width.Should().Be(5);
        trees.Visible.Should().Be(21);
        trees.HighestScenicScore.Should().Be(8);

        trees.Up(1, 1).Should().Equal(0);
        trees.Up(2, 1).Should().Equal(5, 0);

        trees.Left(1, 1).Should().Equal(2);
        trees.Left(1, 2).Should().Equal(5, 2);

        trees.Right(1, 1).Should().Equal(5, 1, 2);
        trees.Right(1, 2).Should().Equal(1, 2);

        trees.Down(1, 1).Should().Equal(5, 3, 5);
        trees.Down(2, 1).Should().Equal(3, 5);
    }
}