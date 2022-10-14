using System.Text;

namespace Diamond.Core
{
    public class DiamondPrinter
    {
        private const string AvailableChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public string Print(char letter)
        {
            var letterIndex = AvailableChars.IndexOf(letter);

            if (letterIndex < 0)
            {
                throw new ArgumentException($"Character '{letter}' not supported");
            }

            var sb = PrintTopOfDiamond(letterIndex);

            var topHalf = sb.ToString();
            if (letter == 'A')
            {
                return topHalf;
            }

            PrintBottomOfDiamond(topHalf, sb);

            return sb.ToString();
        }

        private static void PrintBottomOfDiamond(string topHalf, StringBuilder sb)
        {
            var lines = topHalf.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            for (var i = lines.Length - 2; i >= 0; i--)
            {
                sb.AppendLine(lines[i]);
            }
        }

        private static StringBuilder PrintTopOfDiamond(int letterIndex)
        {
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

            return sb;
        }
    }
}