using System;
using System.Numerics;

namespace _14factorial_trailing_zones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialOfN = GetFactorialOfN(n);
            Console.WriteLine(GetTrailingZeroesOfFactorial(factorialOfN));
        }

        private static int GetTrailingZeroesOfFactorial(BigInteger factorialOfN)
        {
            int sumZeroes = 0;
            while (factorialOfN % 10 == 0)
            {
                if (factorialOfN % 10 == 0)
                {
                    sumZeroes += 1;
                }
                factorialOfN /= 10;
            }
            return sumZeroes;
        }

        private static BigInteger GetFactorialOfN(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
            
        }
    }
}
