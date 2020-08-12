using System;

namespace _05diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n % 2 == 0)
            {
                int middleSpace = 0;
                int leftRightDots = (n - 2) / 2;
                for (int i = 0; i < n /2 ; i++)
                {
                    Console.WriteLine(
                        new string('-', leftRightDots) + "*" +
                        new string('-', middleSpace) + "*" +
                        new string('-', leftRightDots));
                    middleSpace += 2;
                    leftRightDots--;
                }
                middleSpace -= 4;
                leftRightDots+= 2;

                for (int i = 0; i < (n/2) - 1; i++)
                {
                    Console.WriteLine(
                        new string('-', leftRightDots) + "*" +
                        new string('-', middleSpace) + "*" +
                        new string('-', leftRightDots));
                    middleSpace -= 2;
                    leftRightDots++;
                }
            }
            else
            {
                Console.WriteLine(new string('-',(n-1)/2) + "*" + new string('-', (n - 1) / 2));

                int middleSpace = 1;
                int leftRightDots = (n - 3) / 2;
                for (int i = 0; i < n/2; i++)
                {
                    Console.WriteLine(
                        new string('-', leftRightDots) + "*" +
                        new string('-', middleSpace) + "*" +
                        new string('-', leftRightDots));
                    middleSpace += 2;
                    leftRightDots--;
                }

                middleSpace -= 4;
                leftRightDots += 2;

                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine(
                        new string('-', leftRightDots) + "*" +
                        new string('-', middleSpace) + "*" +
                        new string('-', leftRightDots));
                    middleSpace -= 2;
                    leftRightDots++;
                }

                Console.WriteLine(new string('-', (n - 1) / 2) + "*" + new string('-', (n - 1) / 2));
            }
        }
    }
}
