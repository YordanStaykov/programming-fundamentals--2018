using System;
using System.Linq;
using System.Text;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int multiply = 0;
            int reminder = 0;
            int num = 0;
            StringBuilder totalMultiply = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                multiply = (firstNumber[i] - 48) * secondNumber + reminder;
                num = multiply % 10;

                if (multiply > 9)
                {
                    reminder = multiply / 10;
                }
                else
                {
                    reminder = 0;
                }

                totalMultiply.Append(num);
            }
            if (reminder > 0)
            {
                totalMultiply.Append(reminder);
            }


            Console.WriteLine(totalMultiply.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());




        }
    }
}
