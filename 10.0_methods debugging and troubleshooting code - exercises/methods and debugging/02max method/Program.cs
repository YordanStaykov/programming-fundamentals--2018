using System;

namespace _02max_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int biggerFromFirstTwo = GetMax(first, second);
            int biggerFromSecondTwo = GetMax(second, third);
            int biggersNumber = GetMax(biggerFromFirstTwo, biggerFromSecondTwo);
            Console.WriteLine(biggersNumber);
        }

        static int GetMax(int first, int second)
        {
            if (first >= second )
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
