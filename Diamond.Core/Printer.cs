using System.Text;

namespace Diamond.Core
{
    public class DiamondPrinter
    {
        private const string AvailableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string Print(char letter)
        {
            var letterIndex = AvailableChars.IndexOf(letter);
            var sb = new StringBuilder();

            for (var i = 0; i <= letterIndex; i++)
            {
                var spacesBeforeCount = letterIndex - i;
                var spacesBefore = new string(' ', spacesBeforeCount);

                var currentLetter = AvailableChars[i];
                if (currentLetter == 'A')
                {
                    sb.AppendLine($"{spacesBefore}A");
                }
                else
                {
                    var spacesBetweenCount = i * 2 - 1;
                    var spacesBetween = new string(' ', spacesBetweenCount);
                    sb.AppendLine($"{spacesBefore}{currentLetter}{spacesBetween}{currentLetter}");
                }
            }

            var firstHalf = sb.ToString();
            if (letter == 'A')
            {
                return firstHalf;
            }

            var lines = firstHalf.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            for (int i = lines.Length - 2; i >= 0; i--)
            {
                sb.AppendLine(lines[i]);
            }

            return sb.ToString();
        }
    }
}