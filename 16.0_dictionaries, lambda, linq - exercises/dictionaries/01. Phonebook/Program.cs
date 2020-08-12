using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                input = Console.ReadLine();
            }
        }
    }
}
