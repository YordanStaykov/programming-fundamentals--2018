using System;
using System.Collections.Generic;

namespace _03._Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('>');
            int previousStrenght = 0;
            int inputLength = input.Length;
            List<string> result = new List<string>();
            result.Add(input[0]);

            for (int i = 1; i < inputLength; i++)
            {
                
                string word = input[i];
                int strength = int.Parse(word[0].ToString()) + previousStrenght;
                if (strength <= word.Length)
                {
                    word = word.Remove(0, strength);
                    result.Add(word);
                }
                else
                {
                    previousStrenght = strength - word.Length;
                    strength = word.Length;
                    word = word.Remove(0, strength);
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(">",result));
        }
    }
}
