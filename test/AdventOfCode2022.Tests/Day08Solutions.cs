using AdventOfCode2022.Day08;

namespace AdventOfCode2022.Tests;

public class Day08Solutions
{
    [Fact]
    public void Puzzle1_CountVisibleTrees()
    {
        var trees = new PatchOfTrees(Input.Day08);

        trees.Visible.Should().HaveCount(1672);
    }

    private const string Example =
@"30373
25512
65332
33549
35390";

    [Theory]
    [InlineData(Example, 5, 5, 21)]
    public void Example_CreatesPatchCorrectly(string input, int expectedHeight, int expectedWidth,
        int expectedVisibleCount)
    {
        var trees = new PatchOfTrees(input);

        trees.Height.Should().Be(expectedHeight);
        trees.Width.Should().Be(expectedWidth);
        trees.Visible.Should().HaveCount(expectedVisibleCount);

        trees.Up(1, 1).Should().BeEquivalentTo(new [] { 0 });
        trees.Up(2, 1).Should().BeEquivalentTo(new [] { 0, 5 });

        trees.Left(1, 1).Should().BeEquivalentTo(new [] { 2 });
        trees.Left(1, 2).Should().BeEquivalentTo(new [] { 2, 5 });

        trees.Right(1, 1).Should().BeEquivalentTo(new [] { 5, 1, 2 });
        trees.Right(1, 2).Should().BeEquivalentTo(new [] { 1, 2 });

        trees.Down(1, 1).Should().BeEquivalentTo(new [] { 5, 3, 5 });
        trees.Down(2, 1).Should().BeEquivalentTo(new [] { 3, 5 });
    }
}