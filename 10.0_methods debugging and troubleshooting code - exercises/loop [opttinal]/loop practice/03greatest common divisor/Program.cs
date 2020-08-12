using System;

namespace _03greatest_common_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int greaterCommonDivisor = GetGreaterCommonDivisor(a, b);
            Console.WriteLine(greaterCommonDivisor);

        }

        static int GetGreaterCommonDivisor(int a, int b)
        {
            int temp = 0;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            } return a;
        }
    }
}
