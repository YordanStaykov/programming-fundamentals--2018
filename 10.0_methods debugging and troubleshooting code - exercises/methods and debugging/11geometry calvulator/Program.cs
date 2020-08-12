using System;

namespace _11geometry_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double figureArea = GetArea(figure);
            Console.WriteLine($"{figureArea:F2}");
        }

        static double GetArea(string figure)
        {
            double figureArea = 0;
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    figureArea = (side * height) / 2;
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    figureArea = Math.Pow(squareSide, 2);
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    figureArea = rectangleHeight * rectangleWidth;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    figureArea = Math.PI * Math.Pow(radius, 2);
                    break;
            }
            return figureArea;
        }
    }
}
