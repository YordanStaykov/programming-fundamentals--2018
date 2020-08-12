using System;

namespace _05word_in_plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x")
                || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh"))
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }

            Console.WriteLine(word);
        }
    }
}
