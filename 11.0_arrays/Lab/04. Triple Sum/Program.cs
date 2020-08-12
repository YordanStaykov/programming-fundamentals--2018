using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool noSums = true;

            for (int a = 0; a < numbersArr.Length; a++)
            {
                for (int b = 0; b < numbersArr.Length; b++)
                {
                    for (int c = 0; c < numbersArr.Length; c++)
                    {
                        if (numbersArr[a] + numbersArr[b] == numbersArr[c] && a < b)
                        {
                            Console.WriteLine($"{numbersArr[a]} + {numbersArr[b]} == {numbersArr[c]}");
                            noSums = false;
                            break;
                        }
                    }
                }
            }
            if (noSums)
            {
                Console.WriteLine("No");
            }
        }
    }
}
