using System;

namespace _07math_power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int numPower = int.Parse(Console.ReadLine());
            double result = RaiseToPower(num, numPower);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double number, int power)
        {
            double result = 1;
            for (int num = 1; num <= power; num++)
            {
                result *= number;
            }
            return result;
        }
    }
}
