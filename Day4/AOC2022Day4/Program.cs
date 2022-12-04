using AOC2022;
using AOC2022Day4;

class Program
{
    private static readonly SectionAssignment _sectionAssignment = new SectionAssignment();

    static void Main()
    {
        var aocFiles = new AocFiles();
        var lines = aocFiles.GetArrayFromFile();
        Part1(lines);
        Console.WriteLine("");
        Part2(lines);
    }

    private static void Part1(string[] lines)
    {
        var result = _sectionAssignment.GetHowManyAssignmentsContainTheOther(lines);
        Console.WriteLine(result);
    }

    private static void Part2(string[] lines)
    {
        var result = _sectionAssignment.GetHowManyAssignmentPairsOverlap(lines);
        Console.WriteLine(result);
    }
}
