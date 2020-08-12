using System;
using System.Linq;
using System.Text;

namespace _01._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
