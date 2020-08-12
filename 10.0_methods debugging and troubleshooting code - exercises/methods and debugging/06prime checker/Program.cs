using System;

namespace _06prime_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(isItPrime(num));
        }

        static bool isItPrime(long num)
        {
            if (num < 2)
            {
                return false;
            }

            for (long i = 2; i <= Math.Abs(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
