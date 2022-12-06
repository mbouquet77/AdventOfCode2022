using AOC2022;
using AOC2022Day6;

class Program
{
    private static readonly Marker _marker = new Marker();

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
        var result = _marker.GetFirstMarkerIndex(lines[0], 4);
        Console.WriteLine(result);
    }

    private static void Part2(string[] lines)
    {
        var result = _marker.GetFirstMarkerIndex(lines[0], 14);
        Console.WriteLine(result);
    }
}
