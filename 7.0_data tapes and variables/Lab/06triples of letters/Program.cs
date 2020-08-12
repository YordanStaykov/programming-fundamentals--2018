using System;

namespace _06triples_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + numb; i++)
            {
                for (int j = 97; j < 97 + numb; j++)
                {
                    for (int k = 97; k < 97 + numb; k++)
                    {
                        char first = (char)i;
                        char second = (char)j;
                        char third = (char)k;
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }

            //for (int i = 0; i < numb; i++)
            //{
            //    for (int j = 0; j < numb; j++)
            //    {
            //        for (int k = 0; k < numb; k++)
            //        {
            //            char first = (char)('a' + i);
            //            char second = (char)('a' + j);
            //            char third = (char)('a' + k);
            //            Console.Write($"{first}{second}{third}");
            //            Console.WriteLine();
            //        }
            //    }
            //}




        }
    }
}
