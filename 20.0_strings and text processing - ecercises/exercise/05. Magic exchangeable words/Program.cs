using System;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            int firstLength = firstWord.ToCharArray().Distinct().Count();
            int secondLength = secondWord.ToCharArray().Distinct().Count();

            if (firstLength == secondLength)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
