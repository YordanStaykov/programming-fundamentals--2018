using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>(); 

            foreach (var word in words)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                if (reversedWord == word)
                {
                  
                        palindromes.Add(reversedWord);
                    
                }
            }

            palindromes = palindromes.Distinct().ToList();
            Console.WriteLine(string.Join(", ",palindromes.OrderBy(x => x)));
        }
    }
}
