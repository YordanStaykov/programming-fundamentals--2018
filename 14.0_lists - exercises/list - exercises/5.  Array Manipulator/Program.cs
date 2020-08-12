using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.__Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                string[] command = input.Split(' ').ToArray();

                if (command[0] == "add")
                {
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);
                    List<int> elements = new List<int>();
                    for (int i = 2; i < command.Length; i++)
                    {
                        elements.Add(int.Parse(command[i]));
                    }
                    numbers.InsertRange(index, elements);
                }
                else if (command[0] == "contains")
                {
                    Console.WriteLine(numbers.IndexOf(int.Parse(command[1])));
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    int rotations = int.Parse(command[1]);
                    rotations = rotations % numbers.Count;
                    for (int i = 0; i < rotations; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.Remove(numbers[0]);

                    }
                }
                else if (command[0] == "sumPairs")
                {
                    int length = numbers.Count / 2;

                    for (int i = 0; i < length; i++)
                    {
                        int sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }

                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
