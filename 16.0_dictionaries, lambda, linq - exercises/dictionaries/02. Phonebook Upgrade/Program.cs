using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                string[] command = input.Split().ToArray();

                if (command[0].Equals("A"))
                {
                    phonebook[command[1]] = command[2];
                }
                else if (command[0].Equals("S"))
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                else if (command[0].Equals("ListAll"))
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}

