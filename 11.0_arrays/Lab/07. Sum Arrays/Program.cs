using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int firstArrLenght = firstArr.Length;
            int secondArrLenght = secondArr.Length;

            int maxLenght = Math.Max(firstArrLenght, secondArrLenght);

            int[] sum = new int[maxLenght];

            for (int i = 0; i < maxLenght; i++)
            {
                sum[i] = firstArr[i % firstArrLenght] + secondArr[i % secondArrLenght];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
