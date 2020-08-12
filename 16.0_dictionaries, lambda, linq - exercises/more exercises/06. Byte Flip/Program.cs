using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().Where(x => x.Length == 2).ToArray();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                char[] charArr = numbers[i].ToCharArray();
                Array.Reverse(charArr);
                Console.Write(Convert.ToChar(Convert.ToUInt32(new string(charArr), 16)));
            }
            Console.WriteLine();
        }
    }
}
