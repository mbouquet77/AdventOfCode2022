using AOC2022;
using AOC2022Day2;

class Program
{
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
        var rockPaperScissor = new RockPaperScissor();
        var totalScore = rockPaperScissor.GetTotalScore(lines);
        Console.WriteLine(totalScore);
    }

    private static void Part2(string[] lines)
    {
        Console.WriteLine("");
    }
}
