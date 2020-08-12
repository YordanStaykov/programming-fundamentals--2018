using System;

namespace _04numbers_in_reversed_order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversedNumber = ReverseNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static string ReverseNumber(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
