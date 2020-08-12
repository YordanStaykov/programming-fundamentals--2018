using System;

namespace _01christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintChristmasTree(n);

        }

        private static void PrintChristmasTree(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(
                    new string(' ', n - i) +
                    new string('*', i) + " | " +
                    new string('*', i));
            }
        }
    }
}
