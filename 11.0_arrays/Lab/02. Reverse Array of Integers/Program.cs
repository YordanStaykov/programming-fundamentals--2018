using System;
using System.Linq;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int[] numArr = new int[nums];

            for (int i = 0; i < nums; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = nums - 1; i >= 0; i--)
            {
                Console.Write(numArr[i] + " ");    
            }
            Console.WriteLine();

        }
    }
}
