namespace AOC2022Day4
{
    public class SectionAssignment
    {
        public bool DoAssignmentPairsOverlap(string line)
        {
            if (OneAssignmentContainsTheOther(line))
                return true;
            GetAssignmentDetails(line, out int firstAssignmentStart, out int firstAssignmentEnd, out int secondAssignmentStart, out int secondAssignmentEnd);
            if ((firstAssignmentEnd < secondAssignmentStart) ||
                    (secondAssignmentEnd < firstAssignmentStart))
                return false;
            return true;

        }

        public int GetHowManyAssignmentsContainTheOther(string[] lines)
        {
            var result = 0;
            foreach (var line in lines)
            {
                if (OneAssignmentContainsTheOther(line))
                    result++;
            }
            return result;
        }

        public bool OneAssignmentContainsTheOther(string line)
        {
            GetAssignmentDetails(line, out int firstAssignmentStart, out int firstAssignmentEnd, out int secondAssignmentStart, out int secondAssignmentEnd);

            if (firstAssignmentStart == secondAssignmentStart)
                return true;
            if (firstAssignmentStart < secondAssignmentStart)
                return firstAssignmentEnd >= secondAssignmentEnd;
            else
                return firstAssignmentEnd <= secondAssignmentEnd;
        }

        private static void GetAssignmentDetails(string line, out int firstAssignmentStart, out int firstAssignmentEnd, out int secondAssignmentStart, out int secondAssignmentEnd)
        {
            var assignements = line.Split(',');
            var firstAssignment = assignements[0];
            var firstAssignmentDetails = firstAssignment.Split("-");
            firstAssignmentStart = int.Parse(firstAssignmentDetails[0]);
            firstAssignmentEnd = int.Parse(firstAssignmentDetails[1]);
            var secondAssignment = assignements[1];
            var secondAssignmentDetails = secondAssignment.Split("-");
            secondAssignmentStart = int.Parse(secondAssignmentDetails[0]);
            secondAssignmentEnd = int.Parse(secondAssignmentDetails[1]);
        }

        public int GetHowManyAssignmentPairsOverlap(string[] lines)
        {
            var result = 0;
            foreach (var line in lines)
            {
                if (DoAssignmentPairsOverlap(line))
                    result++;
            }
            return result;
        }
    }
}
