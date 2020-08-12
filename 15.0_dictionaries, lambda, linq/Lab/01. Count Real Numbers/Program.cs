using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num) == false)
                {
                    counts[num] = 0;
                }
                counts[num]++;
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
