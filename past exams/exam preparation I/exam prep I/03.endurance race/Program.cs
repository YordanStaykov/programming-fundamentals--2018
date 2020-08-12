using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.endurance_race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (string driver in drivers)
            {
                string output = "";
                double initialFuel = driver[0];
                for (int index = 0; index < zones.Length; index++)
                {
                    if (checkpoints.Contains(index))
                    {
                        initialFuel += zones[index];
                    }
                    else
                    {
                        initialFuel -= zones[index];
                    }
                    if (initialFuel <= 0)
                    {
                        output = $"reached {index}";
                        break;
                    }
                }
                if (initialFuel > 0)
                {
                    output = $"fuel left {initialFuel:F2}";
                }

                Console.WriteLine($"{driver} - {output}");
            }
        }
    }
}
