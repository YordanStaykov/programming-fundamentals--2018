using System;

namespace _10cube_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            PrintParameterValue(side, parameter);
        }

        static void PrintParameterValue(double side, string parameter)
        {
            switch (parameter)
            {
                case "face":
                    double faceDiagonal = GetDiagonalFace(side);
                    Console.WriteLine($"{faceDiagonal:F2}");
                    break;
                case "space":
                    double spaceDiagonal = GetSpaceDiagonal(side);
                    Console.WriteLine($"{spaceDiagonal:F2}");
                    break;
                case "volume":
                    double cubeVolume = GetCubeVolume(side);
                    Console.WriteLine($"{cubeVolume:F2}");
                    break;
                case "area":
                    double cubeArea = GetCubeArea(side);
                    Console.WriteLine($"{cubeArea:F2}");
                    break;
            }
        }

        private static double GetCubeArea(double side)
        {
            double cubeArea = 6 * Math.Pow(side, 2);
            return cubeArea;
        }

        private static double GetCubeVolume(double side)
        {
            double cubeVolume = Math.Pow(side, 3);
            return cubeVolume;
        }

        static double GetSpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonal;
        }

        static double GetDiagonalFace(double side)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonal;
        }
    }


}
