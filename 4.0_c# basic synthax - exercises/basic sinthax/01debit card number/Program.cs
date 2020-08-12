using System;

namespace _01debit_card_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {fourth:d4}");
        }
    }
}
