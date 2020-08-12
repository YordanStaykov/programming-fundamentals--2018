using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            int[] result = new int[numArray.Length];

            for (int rotations = 0; rotations < rotation; rotations++)
            {
                int lastDigit = numArray[numArray.Length - 1];

                for (int i = numArray.Length - 1; i > 0; i--)
                {
                    numArray[i] = numArray[i - 1];
                    result[i] += numArray[i];
                }

                numArray[0] = lastDigit;
                result[0] += numArray[0];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
