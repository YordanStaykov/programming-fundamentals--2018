using System;

namespace _09count_the_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int numb = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }
    }
}
