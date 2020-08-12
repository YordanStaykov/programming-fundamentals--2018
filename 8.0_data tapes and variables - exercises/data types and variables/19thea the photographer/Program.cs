using System;

namespace _19thea_the_photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long allPics = long.Parse(Console.ReadLine());
            long filterTimeInSec = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            long uploadTimeInSec = long.Parse(Console.ReadLine());
            double filterPercent = filterFactor / 100;

            double filteredPics = Math.Ceiling(allPics * filterPercent);
            long filteringTime = allPics * filterTimeInSec;
            long uploadlongime = (long)filteredPics * uploadTimeInSec;
            long totalTimeInSec = filteringTime + uploadlongime;


            TimeSpan span = TimeSpan.FromSeconds(totalTimeInSec);

            string spaned = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                            span.Days,
                            span.Hours,
                            span.Minutes,
                            span.Seconds);
            Console.WriteLine(spaned);

        }
    }
}
