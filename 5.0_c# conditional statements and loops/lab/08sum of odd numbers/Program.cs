using System;

namespace _08sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numb * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;

                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
