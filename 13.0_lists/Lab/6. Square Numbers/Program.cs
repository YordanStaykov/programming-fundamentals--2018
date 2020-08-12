using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Square_Numbers
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

            foreach (int num in numbers)
            {
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    selected.Add(num);
                }
            }

            selected = selected.OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join(" ",selected));


        }
    }
}
