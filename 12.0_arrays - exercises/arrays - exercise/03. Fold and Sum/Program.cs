using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] leftArr = numbers.Take(k).ToArray();
            int[] middleArr = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = numbers.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArr); 
            Array.Reverse(rightArr);

            int[] result = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftArr[i] + middleArr[i];
                result[i + k] = rightArr[i] + middleArr[i + k];
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
