using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            long[] sequence = new long[firstNum];
            sequence[0] = 1;

            for (int i = 1; i < firstNum; i++)
            {
                long sum = 0;
                int start = Math.Max(0, i - secondNum);
                for (int j = start; j <= i; j++)
                {
                    sum += sequence[j];
                }
                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
