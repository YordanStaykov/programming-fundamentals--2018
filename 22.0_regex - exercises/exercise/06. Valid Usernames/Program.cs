using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b[a-zA-Z][\w]{2,26}\b";

            MatchCollection matches = Regex.Matches(input,pattern);

            string[] validUsers = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            int sum = 0;
            string firstWord = "";
            string secondWord = "";
            for (int count = 1; count < validUsers.Length ; count++)
            {
                int currentSum = 0;
                currentSum = validUsers[count].Length + validUsers[count - 1].Length;
                if (currentSum > sum)
                {
                    sum = currentSum;
                    firstWord = validUsers[count - 1];
                    secondWord = validUsers[count];
                }
            }

            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
        }
    }
}
