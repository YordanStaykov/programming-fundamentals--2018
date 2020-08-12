using System;
using System.Text.RegularExpressions;

namespace _05._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersInput = Console.ReadLine(); 
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection numbers = Regex.Matches(numbersInput, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
