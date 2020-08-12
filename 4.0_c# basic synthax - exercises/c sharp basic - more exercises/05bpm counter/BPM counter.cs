using System;

namespace _05bpm_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());
            double bars = (double)numberOfBeats / 4;

            double beatsInSeconds = (double)bpm / 60;
            double timeBeating = numberOfBeats / beatsInSeconds;
            int minutes = (int)timeBeating / 60;
            double seconds = timeBeating % 60;
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {Math.Floor(seconds)}s");
        }
    }
}
