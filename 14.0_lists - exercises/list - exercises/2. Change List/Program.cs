using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comande = Console.ReadLine();

            while (comande != "Odd" && comande != "Even")
            {
                string[] comandeArr = comande.Split(' ').ToArray();

                if (comandeArr[0] == "Delete")
                {
                    int element = int.Parse(comandeArr[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }

                    } 
                }
                else if (comandeArr[0] == "Insert")
                {
                    int element = int.Parse(comandeArr[1]);
                    int position = int.Parse(comandeArr[2]);

                    numbers.Insert(position, element);
                }


                comande = Console.ReadLine();
            }

            if (comande == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else if (comande == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
