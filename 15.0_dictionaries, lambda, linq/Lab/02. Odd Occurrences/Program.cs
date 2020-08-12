using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (counts.ContainsKey(word) == false)
                {
                    counts[word] = 0;
                }
                counts[word]++;

            }

            List<string> result = new List<string>();

            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
