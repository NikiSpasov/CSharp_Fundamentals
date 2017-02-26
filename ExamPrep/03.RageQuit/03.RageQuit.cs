namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Regex symbols = new Regex(@"[^\d]+");
            Regex nums = new Regex(@"[0-9]+");
            Regex textWithoutNums = new Regex(@"[^\d]+");

            MatchCollection symbolGroups = symbols.Matches(text);
            MatchCollection numGroups = nums.Matches(text);
            StringBuilder textResult = new StringBuilder();
            int j = 0;

            foreach (Match symbolGroup in symbolGroups)
            {
                int numLoop = int.Parse(numGroups[j].ToString());
                for (int i = 0; i < numLoop; i++)
                {
                    textResult.Append(symbolGroup.ToString().ToUpper());
                }
                j++;
            }

            StringBuilder onlyText = new StringBuilder();

            foreach (Match match in symbolGroups)
            {
                onlyText.Append(match);
            }

            string currentText = onlyText.ToString().ToUpper();
            var finalText = currentText.Distinct();
            int count = finalText.Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(textResult);
        }

    }
}
