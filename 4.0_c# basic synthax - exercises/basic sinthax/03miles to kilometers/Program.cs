using System;

namespace _03miles_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 1.60934;
            Console.WriteLine($"{miles:F2}");
        }
    }
}
