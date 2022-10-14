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
                var currentLetter = AvailableChars[i];
                if (currentLetter == 'A')
                {
                    sb.Append("A");
                }
                else
                {
                    sb.Append($"{currentLetter}{currentLetter}");
                }
            }

            return sb.ToString();
        }
    }
}