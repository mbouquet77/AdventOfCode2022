namespace AOC2022Day5
{
    public class MovingCrates
    {
        public List<List<string>> ApplyInstruction(List<List<string>> input, string instruction)
        {
            var details = instruction.Split(' ');
            var nbCratesToMove = int.Parse(details[1]);
            var source = int.Parse(details[3]);
            var dest = int.Parse(details[5]);
            var newDestLine = new List<string>();
            var newSourceLine = new List<string>();
            newDestLine.AddRange(input[dest - 1]);
            newSourceLine.AddRange(input[source - 1]);

            for (int i = 0; i < nbCratesToMove; i++)
            {
                newDestLine.Add(newSourceLine.Last());
                newSourceLine.RemoveAt(newSourceLine.Count()-1);
            }

            input[dest - 1] = newDestLine;
            input[source - 1] = newSourceLine;
            return input;
        }

        public string GetMessage(List<string> input, List<string> instructions)
        {
            var lastInput = Rearrangement(input, instructions);
            var message = string.Empty;
            foreach (var line in lastInput)
            {
                message+= line.Last();
            }
            return message;
        }

        public List<List<string>> GetMyInputList(List<string> input)
        {
            var result = new List<List<string>>();
            var len = input[0].Length;
            var nbColumns = (len + 1) / 4;
            for (int i = 0; i < nbColumns; i++)
            {
                var listCol = new List<string>();
                for (int j = input.Count - 2; j >= 0; j--)
                {
                    var line = input[j];
                    var letter = line.Substring(i * 4 + 1, 1);
                    if (letter == " ")
                        break;
                    listCol.Add(letter);
                }

                result.Add(listCol);
            }
            return result;
        }

        public List<List<string>> Rearrangement(List<string> input, List<string> instructions)
        {
            var myInputList = GetMyInputList(input);
            foreach(var instruction in instructions)
            {
                myInputList = ApplyInstruction(myInputList, instruction);
            }
            return myInputList;
        }
    }
}
