using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            string firstNumber = input[0];
            string secondNumber = input[1];
            string pattern = @"\|<(?<one>[\w]{" + firstNumber +  @"})(?<two>[\w]{0," + secondNumber + @"})";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);

            List<string> values = new List<string>();
            foreach (Match match in matches)
            {
             
                string value = match.Groups["two"].Value;
                values.Add(value);
            }

            Console.WriteLine(string.Join(", ",values));
        }
    }
}
