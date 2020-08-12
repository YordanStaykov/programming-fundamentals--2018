using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numberList = Console.ReadLine()
                .Split(' ').ToList();

            int result = 0;

            for (int i = 0; i < numberList.Count; i++)
            {
                string currentWord = numberList[i];
                string reversed = new string(currentWord.ToCharArray().Reverse().ToArray());

                result += int.Parse(reversed);
            }

            Console.WriteLine(result);
                
        }
    }
}
