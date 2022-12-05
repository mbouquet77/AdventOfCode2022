namespace AOC2022
{
    public class AocFiles
    {
        public string[] GetArrayFromFile()
        {
            return File.ReadAllLines(@"..\..\..\input.txt");
        }
    }
}
