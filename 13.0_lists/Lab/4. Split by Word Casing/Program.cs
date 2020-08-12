using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(",;:.!()\"'\\ /[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();

            foreach (string word in input)
            {
                if (IsLowerCaseWord(word))
                {
                    lowerCase.Add(word);
                }
                else if (IsUpperCaseWord(word))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ",mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ",upperCase)}");



        }

        static bool IsUpperCaseWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsLowerCaseWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
