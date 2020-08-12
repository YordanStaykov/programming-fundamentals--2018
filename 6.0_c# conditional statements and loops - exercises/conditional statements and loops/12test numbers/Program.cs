using System;

namespace _12test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int sum = 3 * (i * j);
                    totalSum += sum;
                    count++;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
