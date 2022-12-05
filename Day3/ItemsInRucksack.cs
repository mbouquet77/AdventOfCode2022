namespace AOC2022Day3
{
    public class ItemsInRucksack
    {
        public int CharValue(char c)
        {
            if (c.ToString() == c.ToString().ToUpper())
                return c - 38;
            else
                return c - 96;
        }

        public int GetCommonItemsSum(string[] lines)
        {
            var sum = 0;
            foreach (var line in lines)
            {
                var commonItem = GetCommonItemType(line);
                var value = CharValue(commonItem.Value);
                sum += value;
            }
            return sum;
        }

        public char? GetCommonItemType(string line)
        {
            var len = line.Length;
            var firstHalf = line.Substring(0, len / 2);
            var secondHalf = line.Substring(len / 2);
            foreach (var c in firstHalf)
            {
                if (secondHalf.Contains(c))
                    return c;
            }
            return null;
        }

        public char? GetThreeElvesCommonItem(string[] lines)
        {
            var line1 = lines[0];
            var line2 = lines[1];
            var line3 = lines[2];
            foreach (var c in line1)
            {
                if (line2.Contains(c) && line3.Contains(c))
                    return c;
            }
            return null;
        }

        public int GetThreeElvesCommonItemSum(string[] lines)
        {
            var sum = 0;
            var lastLine = 3;
            while (lastLine <= lines.Length + 1)
            {
                var line1 = lines[lastLine - 3];
                var line2 = lines[lastLine - 2];
                var line3 = lines[lastLine - 1];
                var linesToCompare = new string[]
                {
                    line1,
                    line2,
                    line3
                };
                var badge = GetThreeElvesCommonItem(linesToCompare);
                sum += CharValue(badge.Value);
                lastLine += 3;
            }

            return sum;
            
        }
    }
}
