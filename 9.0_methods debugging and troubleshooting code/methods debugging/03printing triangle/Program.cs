using System;

namespace _03printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintLine(int start, int end)
        {
            for (int line = start; line <= end; line++)
            {
                Console.Write(line + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >=  1; line--)
            {
                PrintLine(1, line);
            }
        }
    }
}
