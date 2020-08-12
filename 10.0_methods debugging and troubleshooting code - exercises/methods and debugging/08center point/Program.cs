using System;

namespace _08center_podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToCenter(first, second);
            double secondDistance = GetDistanceToCenter(third, fourth);


            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({first}, {second})");
            }
            else
            {
                Console.WriteLine($"({third}, {fourth})");
            }
        }

        static double GetDistanceToCenter(double first, double second)
        {
            double distanceToCenter = Math.Sqrt(((Math.Pow(first, 2) + Math.Pow(second, 2))));
            return distanceToCenter;
        }
    }
}
