using System;
using System.Linq;

namespace _03._Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int[] numbers = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
