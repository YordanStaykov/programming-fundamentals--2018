using System;

namespace _12number_checker
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                int numb = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
