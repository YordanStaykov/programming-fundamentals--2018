using System;

namespace _10triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numb; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
