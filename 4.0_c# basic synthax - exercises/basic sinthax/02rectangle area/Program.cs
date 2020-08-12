using System;

namespace _02rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            float widht = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float area = widht * height;
            Console.WriteLine($"{area:f2}");
        }
    }
}
    
