using AdventOfCode2022.Day01;

namespace AdventOfCode2022.Tests;

public class Day01Solutions
{
    [Fact]
    public void Puzzle_FindMostCalories()
    {
        var inventory = new Inventory(Input.Day01);

        inventory.Select(x => x.Calories).Max().Should().Be(68802);
        inventory.OrderByDescending(x => x.Calories).Take(3).Sum(x => x.Calories).Should().Be(205370);
    }

    public static string Example =
@"000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

    [Fact]
    public void PuzzleExample_CountsElves_AndFindsMostCalories()
    {
        var inventory = new Inventory(Example);

        inventory.Should().HaveCount(5);
        inventory.Select(x => x.Calories).Max().Should().Be(24000);
        inventory.OrderByDescending(x => x.Calories).Take(3).Sum(x => x.Calories).Should().Be(45000);
    }
}