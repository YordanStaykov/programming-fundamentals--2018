using System;

namespace _04number_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    if (count == n)
                    {
                        Console.WriteLine();
                        return;
                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
