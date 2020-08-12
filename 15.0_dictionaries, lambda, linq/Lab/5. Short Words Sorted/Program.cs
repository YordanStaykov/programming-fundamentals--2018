using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"'\\/!? ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", input));


        }
    }
}
