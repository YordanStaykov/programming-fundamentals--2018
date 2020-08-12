using System;
using System.Collections.Generic;
using System.Linq;

namespace p05_ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsCount = int.Parse(Console.ReadLine());

            var allPoints = new List<Point>();
            Point firstMinPoint = null;
            Point secondMinPoint = null;

            for (int i = 0; i < pointsCount; i++)
            {
                Point currentPoint = ReadPoint();

                allPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;

            for (int i = 0; i < pointsCount; i++)
            {
                for (int j = i + 1; j < pointsCount; j++)
                {
                    Point firstPoint = allPoints[i];
                    Point secondPoint = allPoints[j];

                    double currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstMinPoint.Display());
            Console.WriteLine(secondMinPoint.Display());
        }

        public static Point ReadPoint()
        {
            int[] pointData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point { X = pointData[0], Y = pointData[1] };
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
