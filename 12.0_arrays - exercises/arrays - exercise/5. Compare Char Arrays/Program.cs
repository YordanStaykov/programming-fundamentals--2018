using System;
using System.Linq;

namespace _5._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int length = Math.Min(first.Length, second.Length);

            for (int i = 0; i < length; i++)
            {
                if (first[i] < second[i])
                {
                    PrintFirstInfront(first, second);
                    return;
                }
                else if (second[i] < first[i])
                {
                    PrintSecondInfront(first, second);
                    return;
                }

            }

            if (first.Length <= second.Length)
            {
                PrintFirstInfront(first, second);
            }
            else
            {
                PrintSecondInfront(first, second);
            }
        }

        private static void PrintSecondInfront(char[] first, char[] second)
        {
            Console.WriteLine(string.Join("", second));
            Console.WriteLine(string.Join("", first));
        }

        private static void PrintFirstInfront(char[] first, char[] second)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
    }
}
