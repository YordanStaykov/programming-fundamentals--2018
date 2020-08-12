using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (numbers.Count > 1)
            {
                List<int> indexToAvoid = new List<int>();
                for (int atacker = 0; atacker < numbers.Count - 1; atacker++)
                {
                    if (indexToAvoid.Contains(atacker))
                    {
                        continue;
                    }
                    if (numbers.Count - indexToAvoid.Count == 1)
                    {
                        break;
                    }
                    int attackerIndex = atacker;                                 
                    int target = numbers[attackerIndex] % numbers.Count;
                    

                    if (target == attackerIndex)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        indexToAvoid.Add(attackerIndex);
                        numbers[attackerIndex] = -1;
                        continue;
                    }
                    int diff = Math.Abs(attackerIndex - target);
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {target} -> {attackerIndex} wins");
                        indexToAvoid.Add(target);
                        numbers[target] = -1;

                    }
                    else
                    {
                        Console.WriteLine($"{attackerIndex} x {target} -> {target} wins");
                        indexToAvoid.Add(attackerIndex);
                        numbers[attackerIndex] = -1;

                    }
                    indexToAvoid = indexToAvoid.Distinct().ToList();

                }
                numbers = numbers.Where(x => x > -1).ToList();
            }
        }
    }
}
