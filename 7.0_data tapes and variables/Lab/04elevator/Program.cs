using System;

namespace _04elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(1.0 * people/ capacity));
        }
    }
}
