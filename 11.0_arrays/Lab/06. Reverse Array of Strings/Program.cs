using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string[] reversedInput = input.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", reversedInput));
        }
    }
}
