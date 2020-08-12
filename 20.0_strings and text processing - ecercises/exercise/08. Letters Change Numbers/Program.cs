using System;
using System.Numerics;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions
                .RemoveEmptyEntries);

            double sum = 0;

            foreach (var token in input)
            {
                double number = double.Parse(token.Substring(1, token.Length - 2));
                if (IsLowerCase(token[0]))
                {
                    number *= (token[0] - 96);
                }
                else
                {
                    number /= (token[0] - 64);
                }

                if (IsLowerCase(token[token.Length - 1]))
                {
                    number += (token[token.Length - 1] - 96);
                }
                else
                {
                    number -= (token[token.Length - 1] - 64);
                }

                sum += number;
            }

            Console.WriteLine("{0:f2}",sum);
        }

        private static bool IsLowerCase(char letter)
        {
            if (letter < 97 || letter > 123)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
