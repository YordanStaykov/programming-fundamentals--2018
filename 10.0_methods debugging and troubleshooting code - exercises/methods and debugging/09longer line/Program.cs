using System;

namespace _09longer_line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double point1 = GetDistanceToCenter(x1, y1);
            double point2 = GetDistanceToCenter(x2, y2);
            double point3 = GetDistanceToCenter(x3, y3);
            double point4 = GetDistanceToCenter(x4, y4);

            double line1 = GetLine(x1, y1, x2, y2);
            double line2 = GetLine(x3, y3, x4, y4);

            if (line1 > line2 && point1 <= point2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (line1 > line2 && point1 > point2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (line2 > line1 && point3 <= point4)
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else if (line2 > line1 && point3 > point4)
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
            else if (line1 = line2 && )
            {

            }

        }

        private static double GetLine(double x1, double x2, double y1, double y2)
        {
            double line = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return line;
        }

        static double GetDistanceToCenter(double x1, double y1)
        {
            double distanceToCenter = Math.Sqrt(((x1 * x1) + (y1 * y1)));
            return distanceToCenter;
        }
    }
}
