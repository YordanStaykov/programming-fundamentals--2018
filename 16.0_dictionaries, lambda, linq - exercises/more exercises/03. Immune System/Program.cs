using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            long initialHealth = long.Parse(Console.ReadLine());
            long currentHealth = initialHealth;
            string virusInput = Console.ReadLine();
            
            Dictionary<string, int> virusOccurances = new Dictionary<string, int>();



            while (virusInput != "end")
            {
                long virusStrenght = 0;
                long timeToDefeat = 0;

                for (int i = 0; i < virusInput.Length; i++)
                {
                    virusStrenght += virusInput[i];
                }

                virusStrenght /= 3;
                timeToDefeat = virusStrenght * virusInput.Length;

                if (virusOccurances.ContainsKey(virusInput) == false)
                {
                    virusOccurances[virusInput] = 1;
                }
                else
                {
                    virusOccurances[virusInput]++;
                }


                if (virusOccurances[virusInput] > 1)
                {
                    timeToDefeat /= 3;
                }


                currentHealth -= timeToDefeat;

                

                long timeToDefeatInMin = timeToDefeat / 60;
                long timeToDefeatInSec = timeToDefeat % 60;

                Console.WriteLine($"Virus {virusInput}: {virusStrenght} => {timeToDefeat} seconds");
                if (currentHealth <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                Console.WriteLine($"{virusInput} defeated in {timeToDefeatInMin}m {timeToDefeatInSec}s.");
                Console.WriteLine($"Remaining health: {(int)currentHealth}");

                currentHealth = currentHealth + (long)(currentHealth * 0.2);
                if (currentHealth > initialHealth)
                {
                    currentHealth = initialHealth;
                }
                

                virusInput = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {(int)currentHealth}");
        }
    }
}
