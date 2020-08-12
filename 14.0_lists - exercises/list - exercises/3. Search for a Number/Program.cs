using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] threeNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int numberOfElementsTaken = threeNumbers[0];
            int numberOfElementsToDelete = threeNumbers[1];
            int searchedNumber = threeNumbers[2];

            numbers = numbers.Take(numberOfElementsTaken).ToList();
            numbers.RemoveRange(0, numberOfElementsToDelete);

            if (numbers.Contains(searchedNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
