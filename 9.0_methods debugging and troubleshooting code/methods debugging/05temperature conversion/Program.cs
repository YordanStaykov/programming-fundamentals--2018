using System;

namespace _05temperature_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FarenheitToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }

        static double FarenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
