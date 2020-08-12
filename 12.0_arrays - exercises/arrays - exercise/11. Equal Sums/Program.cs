using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                
                int sumLeftSide = 0;
                int sumRightSide = 0;

                for (int l = 0; l < i; l++)
                {
                    sumLeftSide += numbers[l];
                }

                for (int r = i + 1; r < numbers.Length; r++)
                {
                    sumRightSide += numbers[r];
                }


                if (sumLeftSide == sumRightSide)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

            Console.WriteLine("no");
            
        }
    }
}
