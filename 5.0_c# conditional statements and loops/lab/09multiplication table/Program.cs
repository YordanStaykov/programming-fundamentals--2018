using System;

namespace _09multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",numb , i, numb * i);
            }
        }
    }
}
