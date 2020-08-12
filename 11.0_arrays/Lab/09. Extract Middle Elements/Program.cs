using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            PrintMiddleOneTwoOrThreeElements(numArr);
        }

        static void PrintMiddleOneTwoOrThreeElements(int[] numArr)
        {
            if (numArr.Length == 1)
            {
                Console.WriteLine($"{{ {numArr[0]} }}");
            }
            else if (numArr.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {numArr[(numArr.Length / 2) - 1]}, {numArr[numArr.Length / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {numArr[(numArr.Length / 2) - 1]}" +
                    $", {numArr[numArr.Length / 2]}, {numArr[(numArr.Length / 2) + 1]} }}");
            }
        }
    }
}
