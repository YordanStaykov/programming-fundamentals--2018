using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = $@"\b[{Console.ReadLine()}]+\b";
            string[] text = Console.ReadLine().Split(new char[] { '.', '!', '?', }, StringSplitOptions.RemoveEmptyEntries);
 
            foreach (string sentence in text)
            {
                bool match = Regex.IsMatch(sentence, pattern);
                if (match)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        
        }
    }
}
