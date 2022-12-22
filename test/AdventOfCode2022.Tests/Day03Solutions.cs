using AdventOfCode2022.Day03;

namespace AdventOfCode2022.Tests;

public class Day03Solutions
{
    [Fact]
    public void Puzzle1_CountSumOfPriority()
    {
        var rucksacks = new Rucksacks(Input.Day03);

        rucksacks.Sum(x => x.Priority).Should().Be(8185);
    }

    [Fact]
    public void Rucksack_Compartments_SplitProperly()
    {
        const string items = "vJrwpWtwJgWrhcsFMMfFFhFp";

        var rucksack = new Rucksack(items);

        rucksack.First.Should().BeEquivalentTo("vJrwpWtwJgWr");
        rucksack.Second.Should().BeEquivalentTo("hcsFMMfFFhFp");
        rucksack.MostCommon.Should().Be('p');
        rucksack.Priority.Should().Be(16);
    }

    private const string Puzzle1Example =
@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";

    [Fact]
    public void Puzzle1Example_CountSumOfPriority()
    {
        var rucksacks = new Rucksacks(Puzzle1Example);

        rucksacks.Sum(x => x.Priority).Should().Be(157);
    }
}