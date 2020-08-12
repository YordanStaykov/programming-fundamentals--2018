using System;
using System.Linq;

namespace _01._Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] timeArray = Console.ReadLine().Split().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ",timeArray));
        }
    }
}
