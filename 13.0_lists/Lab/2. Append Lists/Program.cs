using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] {'|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            input.Reverse();

            foreach (var item in input)
            {
                int[] array = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                Console.Write(string.Join(" ", array) + " ");
            }

            Console.WriteLine();
        }
    }
}
