using System;
using System.Linq;

namespace _02._Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();

            double average = numbers.Average();

            for (int i = 0; i < numbers.Length; i++)

            {
                if (numbers[i] > average)
                {
                    numbers[i] += 1;
                }
                else
                {
                    numbers[i] -= 1;
                }
            }

             Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
