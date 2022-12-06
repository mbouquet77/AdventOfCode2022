namespace AOC2022Day6
{
    public class Marker
    {
        public int? GetFirstMarkerIndex(string buffer, int length)
        {
            for (int index = 0; index < buffer.Length; index++)
            {
                var input = buffer.Substring(index, length);
                var uniqueCharArray = input.ToCharArray().Distinct().ToArray();
                var resultString = new string(uniqueCharArray);
                if (resultString.Length  == length)
                    return index+length;
            }
            return null;
        }
    }
}
