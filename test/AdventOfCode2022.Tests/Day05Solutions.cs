using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests;

public class Day05Solutions
{
    [Fact]
    public void Puzzle1_FindMessage()
    {
        var crates = new Crates(Input.Day05.Stacks, Input.Day05.Moves);

        crates.Run();

        crates.Message.Should().Be("QGTHFZBHV");
    }

    private const string ExampleStacks =
@"ZN
MCD
P";

    private const string ExampleMoves =
@"move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

    [Fact]
    public void Example_CreatesStacksProperly()
    {
        var crates = new Crates(ExampleStacks, string.Empty);

        crates.Stacks.Should().HaveCount(3);
        crates.Message.Should().Be("NDP");

        crates.Move(1, 2, 1);
        crates.Message.Should().Be("DCP");

        crates.Move(3, 1, 3);
        crates.Message.Should().Be(" CZ");
    }

    [Fact]
    public void Example_RunsCorrectly()
    {
        var crates = new Crates(ExampleStacks, ExampleMoves);

        crates.Run();

        crates.Message.Should().Be("CMZ");
    }
}