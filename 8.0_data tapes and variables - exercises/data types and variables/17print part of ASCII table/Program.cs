using System;

namespace _17print_part_of_ASCII_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
