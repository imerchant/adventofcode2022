using AdventOfCode2022.Day04;

namespace AdventOfCode2022.Tests;

public class Day04Solutions
{
    [Fact]
    public void Puzzle1And2_CountContainingAndOverlappingPairs()
    {
        var assignments = new CleaningAssignments(Input.Day04);

        assignments.Count(x => x.OneContainsTheOther).Should().Be(483);
        assignments.Count(x => x.IsOverlap).Should().Be(874);
    }

    private const string PuzzleExample =
@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8";

    [Fact]
    public void PuzzleExample_CountsContainingAndOverlappingPairs()
    {
        var assignments = new CleaningAssignments(PuzzleExample);

        assignments.Count(x => x.OneContainsTheOther).Should().Be(2);
        assignments.Count(x => x.IsOverlap).Should().Be(4);
    }
}