using System;

namespace _15fast_prime_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int toCheck = 2; toCheck <= number; toCheck++)
            {
                bool isPrime = true;
                for (int delio = 2; delio <= Math.Sqrt(toCheck); delio++)
                {
                    if (toCheck % delio == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{toCheck} -> {isPrime}");
            }

        }
    }
}
