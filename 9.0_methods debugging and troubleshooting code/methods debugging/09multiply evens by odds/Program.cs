using System;

namespace _09multiply_evens_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int evenOddMultiply = GetMultiplyByEvensAndOdds(Math.Abs(numb));
            Console.WriteLine(evenOddMultiply);

        }

        static int GetSumOffOddNumbers(int number)
        {
            int sumOfOddNums = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1)
                {
                    sumOfOddNums += lastDigit;
                }
                number = number / 10;
            }
            return sumOfOddNums;
        }

        static int GetSumOffEvenNumbers(int number)
        {
            int sumOfEvenNums = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEvenNums += lastDigit;
                }
                number = number / 10;
            }
            return sumOfEvenNums;
        }

        static int GetMultiplyByEvensAndOdds(int number)
        {
            int evensSum = GetSumOffEvenNumbers(number);
            int oddSum = GetSumOffOddNumbers(number);
            return evensSum * oddSum;
        }
    }
}
