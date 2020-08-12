using System;

namespace _12master_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (NumberIsPalindrome(i) && SumOfDigitsIsDivisableBy7(i) && HoldsAnEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HoldsAnEvenDigit(int num)
        {
            bool holdsAnEvenDigit = false;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    holdsAnEvenDigit = true;
                }
                num /= 10;
            }
            return holdsAnEvenDigit;
        }

        private static bool SumOfDigitsIsDivisableBy7(int num)
        {
            bool IsDivisableBy7 = false;
            int sumOfDigits = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sumOfDigits += digit;
                num /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                IsDivisableBy7 = true;
            }
            return IsDivisableBy7;

        }

        private static bool NumberIsPalindrome(int num)
        {
            bool isPalindrome = false;
            int oldNum = num;
            int reverse = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }
            if (oldNum == reverse)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
