 using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int result = 0;
            int totalSpotted = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int currentSpotted = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        currentSpotted++;

                        if (currentSpotted > totalSpotted)
                        {
                            totalSpotted = currentSpotted;
                            result = currentNumber;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
