namespace AOC2022Day5
{
    public class MovingCrates
    {
        public List<List<string>> ApplyInstructionMovingOneAtATime(List<List<string>> input, string instruction)
        {
            GetInstructionDetails(instruction, out int nbCratesToMove, out int source, out int dest);
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
            var lastInput = RearrangementMovingOneAtATime(input, instructions);
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

        public List<List<string>> RearrangementMovingOneAtATime(List<string> input, List<string> instructions)
        {
            var myInputList = GetMyInputList(input);
            foreach(var instruction in instructions)
            {
                myInputList = ApplyInstructionMovingOneAtATime(myInputList, instruction);
            }
            return myInputList;
        }

        public List<List<string>> RearrangementMovingAllAtOnce(List<string> input, List<string> instructions)
        {
            var myInputList = GetMyInputList(input);
            foreach (var instruction in instructions)
            {
                myInputList = ApplyInstructionMovingAllAtOnce(myInputList, instruction);
            }
            return myInputList;
        }

        public List<List<string>> ApplyInstructionMovingAllAtOnce(List<List<string>> input, string instruction)
        {
            GetInstructionDetails(instruction, out int nbCratesToMove, out int source, out int dest);
            var newDestLine = new List<string>();
            var newSourceLine = new List<string>();
            newDestLine.AddRange(input[dest - 1]);
            newSourceLine.AddRange(input[source - 1]);

            var rangeToMove = newSourceLine.GetRange(newSourceLine.Count - nbCratesToMove, nbCratesToMove);
            newDestLine.AddRange(rangeToMove);
            for (int i = 0; i < nbCratesToMove; i++)
            {
                newSourceLine.RemoveAt(newSourceLine.Count() - 1);
            }
            input[dest - 1] = newDestLine;
            input[source - 1] = newSourceLine;
            return input;
        }

        private static void GetInstructionDetails(string instruction, out int nbCratesToMove, out int source, out int dest)
        {
            var details = instruction.Split(' ');
            nbCratesToMove = int.Parse(details[1]);
            source = int.Parse(details[3]);
            dest = int.Parse(details[5]);
        }

        public string GetMessageWhenMovingAllAtOnce(List<string> input, List<string> instructions)
        {
            var lastInput = RearrangementMovingAllAtOnce(input, instructions);
            var message = string.Empty;
            foreach (var line in lastInput)
            {
                message += line.Last();
            }
            return message;
        }
    }
}
