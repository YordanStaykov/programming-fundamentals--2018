using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" => ", numbers));
        }
    }
}
