using System;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            int sum = 0;

            int minLength = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            int maxLength = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = minLength; i < maxLength; i++)
            {
                if (firstWord.Length >= secondWord.Length)
                {
                    sum += firstWord[i];
                }
                else
                {
                    sum += secondWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
