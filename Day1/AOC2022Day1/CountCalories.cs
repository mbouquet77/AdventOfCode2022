namespace AOC2022Day1
{
    public class CountCalories
    {
        public Dictionary<int, int> CreateDictionary(string[] lines)
        {
            var elfNumber = 1;
            var totalCalories = 0;
            var dict = new Dictionary<int, int>();
            foreach (var line in lines)
            {
                if (line == string.Empty)
                {
                    dict.Add(elfNumber, totalCalories);
                    elfNumber++;
                    totalCalories = 0;
                }
                else
                {
                    var calorie = int.Parse(line);
                    totalCalories += calorie;
                }
            }
            dict.Add(elfNumber, totalCalories);
            return dict;
        }

        public int GetMaxCalories(string[] lines)
        {
            var dict = CreateDictionary(lines);
            return dict.Max(d => d.Value);
        }

        public int TopThreeCaloriesSum(string[] lines)
        {
            var dict = CreateDictionary(lines);
            var list = dict.Values.ToList();
            var topOne = list.Max();
            list.Remove(topOne);
            var topTwo = list.Max();
            list.Remove(topTwo);
            return list.Max() + topOne + topTwo;
        }
    }
}
