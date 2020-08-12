using System;

namespace _03megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double megapixels = (width * height) / 1000000;

            Console.WriteLine($"{width:f0}x{height:f0} => {Math.Round(megapixels, 1)}MP");
        }
    }
}
