using System;

namespace _04draw_a_filled_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }

        static void PrintFilledSquare(int n)
        {
            PrintEndRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintEndRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintEndRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
