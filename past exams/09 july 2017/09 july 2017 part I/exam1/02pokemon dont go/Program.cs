using System;
using System.Collections.Generic;
using System.Linq;

namespace _02pokemon_dont_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            int index = 0;
            long sum = 0;

            while (numbers.Count > 0)
            {
                index = int.Parse(Console.ReadLine());
                long current = 0;
                if (index < 0)
                {
                    current = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index > numbers.Count - 1)
                {
                    current = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    current = numbers[index];
                    numbers.RemoveAt(index);
                }
                sum += current;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= current)
                    {
                        numbers[i] += current;
                    }
                    else
                    {
                        numbers[i] -= current;
                    }
                }


            }
            Console.WriteLine(sum);
        }
    }
}
