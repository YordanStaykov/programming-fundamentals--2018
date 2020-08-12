using System;

namespace _2._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rab = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rab.Next(words.Length);
                string currentWord = words[pos1];
                string newWord = words[pos2];
                words[pos1] = newWord;
                words[pos2] = currentWord;
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
