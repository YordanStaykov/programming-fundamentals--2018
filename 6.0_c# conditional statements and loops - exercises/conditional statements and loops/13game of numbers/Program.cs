using System;

namespace _13game_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;
                    if (i > j && i + j == magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
