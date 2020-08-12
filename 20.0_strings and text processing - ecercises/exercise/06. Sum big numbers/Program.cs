using System;
using System.Linq;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int firstNumberLength = firstNumber.Length;
            int secondNumberLength = secondNumber.Length;
            int lengthDiff = Math.Abs(firstNumberLength - secondNumberLength);

            if (firstNumberLength > secondNumberLength)
            {
                secondNumber = secondNumber.PadLeft(firstNumberLength, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumberLength, '0');
            }

            int currentSum = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder totalSum = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                currentSum = firstNumber[i] - 48 + secondNumber[i] - 48 + reminder;
                num = currentSum % 10;
                if (currentSum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }

                totalSum.Append(num);
                if (i == 0  && reminder == 1)
                {
                    totalSum.Append(reminder);
                }


            }

            Console.WriteLine(totalSum.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());

        }
    }
}
