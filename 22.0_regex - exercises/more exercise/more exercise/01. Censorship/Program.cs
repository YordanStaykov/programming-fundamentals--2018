using System;
using System.Text.RegularExpressions;

namespace _01._Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(pattern, new string('*',pattern.Length));

            Console.WriteLine(sentence);
        }
    }
}
