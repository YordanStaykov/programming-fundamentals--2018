using System;

namespace _03exaxt_sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < numCount; i++)
            {
                decimal numb = decimal.Parse(Console.ReadLine());
                sum += numb;
            }
            Console.WriteLine(sum);
        }
    }
}
