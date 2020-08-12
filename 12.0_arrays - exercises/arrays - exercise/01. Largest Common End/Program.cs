using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int length = Math.Min(firstArr.Length, secondArr.Length);
            int equalElemnts = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    equalElemnts++;
                }
            }

            firstArr = firstArr.Reverse().ToArray();
            secondArr = secondArr.Reverse().ToArray();

            int reversedElements = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    reversedElements++;
                }
            }

            if (equalElemnts > reversedElements)
            {
                Console.WriteLine(equalElemnts);
            }
            else
            {
                Console.WriteLine(reversedElements);
            }
        }
    }
}
