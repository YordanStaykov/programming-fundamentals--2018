using System;

namespace _03english_name_of_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitInString(Math.Abs(number)));

        }

        static string GetLastDigitInString(long number)
        {
            string lastDigitToString = "";
            long lastDigit = number % 10;
            if (lastDigit == 0)
            {
                lastDigitToString = "zero";
            }
            else if (lastDigit == 1)
            {
                lastDigitToString = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitToString = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitToString = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitToString = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitToString = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitToString = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitToString = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitToString = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitToString = "nine";
            } 
            return lastDigitToString;
        }
    }
}
