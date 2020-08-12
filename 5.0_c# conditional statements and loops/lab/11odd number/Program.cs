using System;

namespace _11odd_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            while (true)
            {

                numb = int.Parse(Console.ReadLine());
                if (numb % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(numb)}");
                    break;
                }
            }
        }
    }
}
