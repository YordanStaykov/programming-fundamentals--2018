using System;

namespace _05fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintFibonacciNumber(num);
        }

        private static void PrintFibonacciNumber(int num)
        {
            int firstNum = 0;
            int secondNum = 1;
            for (int i = 0; i < num; i++)
            {
                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp + secondNum;
            }
            Console.WriteLine(secondNum);
        }
    }
}
