using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int startIndex = 0;
            int currentLentgh = 1;
            int bestStart = 0;
            int bestLentgh = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLentgh++;

                    if (currentLentgh > bestLentgh)
                    {
                        bestLentgh = currentLentgh;
                        bestStart = startIndex;
                    }
                    
                }
                else
                {
                    currentLentgh = 1;
                    startIndex = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLentgh; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
