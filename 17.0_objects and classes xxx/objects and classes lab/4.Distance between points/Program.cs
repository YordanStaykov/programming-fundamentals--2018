using System;
using System.Linq;

namespace p04_DistanceBetweenPoints

{
    class Program
    {

        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();
            double distance = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F3}");
        }

        public static Point ReadPoint()
        {
            int[] PointData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point { X = PointData[0], Y = PointData[1] };
            return point;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double sideA = p1.X - p2.X;

            double sideB = p1.Y - p2.Y;

            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }

    }
}
