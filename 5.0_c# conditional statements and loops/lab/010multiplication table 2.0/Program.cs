using System;

namespace _010multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("{0} X {1} = {2}", numb, multiplier, numb * multiplier);
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
