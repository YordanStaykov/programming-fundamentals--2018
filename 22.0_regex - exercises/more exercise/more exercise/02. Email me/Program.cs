using System;

namespace _02._Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@');
            int afterSum = 0;
            int beforeSum = 0;

            foreach (var letter in email[1])
            {
                afterSum += letter;
            }

            foreach (var letter in email[0])
            {
                beforeSum += letter;
            }

            if (beforeSum - afterSum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
