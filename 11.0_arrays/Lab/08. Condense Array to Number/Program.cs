using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbArr.Length > 1)
            {
                int[] condenced = new int[numbArr.Length - 1];
                for (int i = 0; i < condenced.Length; i++)
                {
                    condenced[i] = numbArr[i] + numbArr[i + 1];
                }
                numbArr = condenced;
            }


            Console.WriteLine(string.Join(" ", numbArr));
        }
    }
}
