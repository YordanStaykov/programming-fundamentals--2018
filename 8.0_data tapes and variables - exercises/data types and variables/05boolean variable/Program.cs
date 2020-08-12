using System;

namespace _05boolean_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool toBoolean = Convert.ToBoolean(word);
            if (toBoolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
