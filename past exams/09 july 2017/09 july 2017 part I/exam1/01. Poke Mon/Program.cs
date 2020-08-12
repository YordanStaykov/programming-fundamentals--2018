using System;

namespace _01._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int countOfTargets = 0;
            int currentPokePower = pokePower;

            while (currentPokePower >= distance)
            {
                currentPokePower -= distance;
                countOfTargets++;

                if (currentPokePower == pokePower / 2)
                {
                    try
                    {
                        currentPokePower /= exhaustionFactor;
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(currentPokePower);
            Console.WriteLine(countOfTargets);
        }
    }
}
