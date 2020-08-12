using System;

namespace _01x
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string row = "";
            int middleSpace = n - 2;
            int leftRightSpaces;

            for (int i = 0; i < n / 2; i++)
            {
                leftRightSpaces = i;
                row = new string(' ', leftRightSpaces) + "x" + new string(' ', middleSpace) + "x";
                middleSpace -= 2;
                Console.WriteLine(row);
            }
            leftRightSpaces = (n - 1) / 2;
            row = new string(' ', leftRightSpaces) + "x" + new string(' ', leftRightSpaces);
            Console.WriteLine(row);
            leftRightSpaces--;
            middleSpace = 1;

            for (int i = 0; i < n / 2; i++)
            {
                row = new string(' ', leftRightSpaces) + "x" + new string(' ', middleSpace) + "x";
                Console.WriteLine(row);
                leftRightSpaces--;
                middleSpace += 2;
            }
        }
    }
}
