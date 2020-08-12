using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> selected = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                selected.Add(0);
            }

            foreach (int num in numbers)
            {
                selected[num]++;
            }

            for (int i = 0; i < selected.Count; i++)
            {
                if (selected[i] > 0)
                {
                    Console.WriteLine($"{i} -> {selected[i]}");
                }
            }

        }
    }
}
