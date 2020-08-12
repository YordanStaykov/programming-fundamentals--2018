using System;
using System.Numerics;

namespace _01._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int snow = 0;
            int time = 0;
            int quality = 0;

            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValueCurrent = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValueCurrent > snowballValue)
                {
                    snowballValue = snowballValueCurrent;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {snowballValue} ({quality})");
        }
    }
}
