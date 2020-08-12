using System;

namespace _11convert_speed_units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = hours * 3600 + minutes * 60 + seconds;

            float metersPerSecond = (float)distance / time;
            float kmPerHour = ((float)distance / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distance / 1609) / ((float)time / 3600);

            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kmPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
