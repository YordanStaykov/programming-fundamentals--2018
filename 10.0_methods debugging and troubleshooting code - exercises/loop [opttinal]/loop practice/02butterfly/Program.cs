using System;

namespace _02butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new string('*',n-2) + "\\ /" + new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(new string('-', n - 2) + "\\ /" + new string('-', n - 2));
                }
            }

            Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(new string('*', n - 2) + "/ \\" + new string('*', n - 2));
                }
                else
                {
                    Console.WriteLine(new string('-', n - 2) + "/ \\" + new string('-', n - 2));
                }
            }
        }
    }
}
