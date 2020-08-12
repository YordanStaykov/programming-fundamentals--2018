using System;

namespace _03._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string sentence = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                sentence = sentence.Replace(banWord, new string('*', banWord.Length));
            }


            Console.WriteLine(sentence);
        }
    }
}
