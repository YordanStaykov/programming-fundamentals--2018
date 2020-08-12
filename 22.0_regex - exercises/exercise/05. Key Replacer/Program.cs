using System;
using System.Text.RegularExpressions;

namespace _05._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyString = Console.ReadLine()
                .Split(new char[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            string startKey = keyString[0];
            string endKey = keyString[keyString.Length-1];

            string pattern = $"{startKey}(.*?){endKey}";
            MatchCollection matches = Regex.Matches(text, pattern);

            string matchesText = "";
            foreach (Match match in matches)
            {
                string currentText = match.Groups[1].Value;
                matchesText += currentText;
            }

            if (matchesText == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(matchesText);
            }


        }
    }
}
