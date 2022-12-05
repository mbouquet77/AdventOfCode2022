namespace AOC2022Day2
{
    public class RockPaperScissor
    {
        public int GetMyScore(string line)
        {
            GetShapes(line, out ShapeEnum opponentShape, out ShapeEnum myShape);

            return myShape switch
            {
                ShapeEnum.Rock => 1,
                ShapeEnum.Paper => 2,
                ShapeEnum.Scissors => 3,
                _ => 0,
            };
        }

        public void GetShapes(string line, out ShapeEnum opponentShape, out ShapeEnum myShape)
        {
            var hands = line.Split(' ');
            opponentShape = GetOpponentShape(hands[0]);
            myShape = GetMyShape(hands[1]);
        }

        private ShapeEnum GetOpponentShape(string opponentHand)
        {
            var shape = ShapeEnum.Rock;
            switch (opponentHand)
            {
                case "A": shape = ShapeEnum.Rock; break;
                case "B": shape = ShapeEnum.Paper; break;
                case "C": shape = ShapeEnum.Scissors; break;
                default:
                    break;
            }
            return shape;
        }

        private ShapeEnum GetMyShape(string myHand)
        {
            var myShape = ShapeEnum.Rock;
            switch (myHand)
            {
                case "X": myShape = ShapeEnum.Rock; break;
                case "Y": myShape = ShapeEnum.Paper; break;
                case "Z": myShape = ShapeEnum.Scissors; break;
                default:
                    break;
            }
            return myShape;
        }

        public HandResult GetHandResult(string line)
        {
            GetShapes(line, out ShapeEnum opponentShape, out ShapeEnum myShape);

            if (opponentShape == myShape)
                return HandResult.Equality;
            return myShape switch
            {
                ShapeEnum.Rock => opponentShape == ShapeEnum.Paper ? HandResult.Lose : HandResult.Win,
                ShapeEnum.Paper => opponentShape == ShapeEnum.Scissors ? HandResult.Lose : HandResult.Win,
                ShapeEnum.Scissors => opponentShape == ShapeEnum.Rock ? HandResult.Lose : HandResult.Win,
                _ => HandResult.Equality,
            };
        }

        public int GetOutcomeScore(string line)
        {
            var handResult = GetHandResult(line);
            return handResult switch
            {
                HandResult.Equality => 3,
                HandResult.Win => 6,
                _ => 0,
            };
        }

        public int GetTotalLineScore(string line)
        {
            return GetMyScore(line) + GetOutcomeScore(line);
        }

        public int GetTotalScore(string[] lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                var lineScore = GetTotalLineScore(line);
                total += lineScore;
            }
            return total;
        }

        public HandResult GetNeededResult(string myHand)
        {
            return myHand switch
            {
                "X" => HandResult.Lose,
                "Y" => HandResult.Equality,
                "Z" => HandResult.Win,
                _ => throw new Exception()
            };
        }

        public ShapeEnum GetNeededHand(string line, out HandResult neededResult)
        {
            var hands = line.Split(' ');
            var opponentShape = GetOpponentShape(hands[0]);
            neededResult = GetNeededResult(hands[1]);

            switch (neededResult)
            {
                case HandResult.Equality:
                    return opponentShape;
                case HandResult.Lose:
                    switch (opponentShape)
                    {
                        case ShapeEnum.Rock:
                            return ShapeEnum.Scissors;
                        case ShapeEnum.Paper:
                            return ShapeEnum.Rock;
                        case ShapeEnum.Scissors:
                            return ShapeEnum.Paper;
                    };
                    throw new Exception();
                case HandResult.Win:
                    switch (opponentShape)
                    {
                        case ShapeEnum.Rock:
                            return ShapeEnum.Paper;
                        case ShapeEnum.Paper:
                            return ShapeEnum.Scissors;
                        case ShapeEnum.Scissors:
                            return ShapeEnum.Rock;
                    }
                    throw new Exception();
            }
            throw new Exception("not implemented case");
        }

        public int GetNeededLineScore(string line)
        {
            var neededHand = GetNeededHand(line, out HandResult neededResult);
            var myScore = neededHand switch
            {
                ShapeEnum.Rock => 1,
                ShapeEnum.Paper => 2,
                ShapeEnum.Scissors => 3,
                _ => 0,
            };

            var outcomeScore = neededResult switch
            {
                HandResult.Equality => 3,
                HandResult.Win => 6,
                _ => 0,
            };

            return myScore + outcomeScore;
        }

        public int GetTotalNeededScore(string[] lines)
        {
            var totalScore = 0;
            foreach (var line in lines)
            {
                totalScore += GetNeededLineScore(line);
            }
            return totalScore;
        }
    }

    public enum ShapeEnum
    {
        Rock,
        Paper,
        Scissors
    }

    public enum HandResult
    {
        Equality,
        Lose,
        Win
    }
}
