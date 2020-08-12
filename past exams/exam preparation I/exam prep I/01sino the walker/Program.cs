using System;
using System.Numerics;

namespace _01sino_the_walker
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeLeaving = TimeSpan.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secPerStep = int.Parse(Console.ReadLine()) % 86400;

            int seconds = steps * secPerStep;
            timeLeaving = timeLeaving.Add(new TimeSpan(0, 0, seconds));
            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}",timeLeaving.Hours,
                timeLeaving.Minutes, timeLeaving.Seconds);
        }
    }
}
