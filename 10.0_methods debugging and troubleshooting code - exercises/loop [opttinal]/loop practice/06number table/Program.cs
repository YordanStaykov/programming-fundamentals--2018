using System;

namespace _06number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                for (int k = i; k <= n; k++)
                {

                }
                Console.WriteLine();
            }
        }
    }
}
