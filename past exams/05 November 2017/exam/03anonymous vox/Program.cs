using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03anonymous_vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string values = Console.ReadLine();

            Regex placeholderRegex = new Regex(@"(?<border>[A-Za-z]+)(?<placeholder>.*)(\k<border>)");
            Regex valuesRegex = new Regex(@"[^{}]+");

            MatchCollection textMatches = placeholderRegex.Matches(encodedText);
            MatchCollection valuesMatches = valuesRegex.Matches(values);


            int length = 0;
            if (valuesMatches.Count < textMatches.Count)
            {
                length = valuesMatches.Count;
            }
            else
            {
                length = textMatches.Count;
            }

            for (int i = 0; i < length; i++)
            {
                encodedText = encodedText.Replace(textMatches[i].Groups["placeholder"].Value, valuesMatches[i].Value);
            }

            Console.WriteLine(encodedText);

        }
    }
}
