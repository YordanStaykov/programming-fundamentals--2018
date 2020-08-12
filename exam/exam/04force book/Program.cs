using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace _04force_book
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> theForceDiaries = new Dictionary<string, List<string>>();


            while (command != "Lumpawaroo")
            {
                bool IsContained = false;
                string forceSide = "";
                string forceUser = "";
                Regex regex = new Regex(@"(?<leftPart>[^\|\-\>]+) (?<sep>\||) (?<rightPart>[^\|\-\>]+)");
                Match match = regex.Match(command);
                
                string separator = match.Groups["sep"].Value;
                if (separator == "|")
                {
                    forceSide = match.Groups["leftPart"].Value;
                    forceUser = match.Groups["rightPart"].Value;

                    foreach (var item in theForceDiaries.Values)
                    {
                        if (item.Contains(forceUser))
                        {
                            IsContained = true;
                        }
                    }

                    if (IsContained == false)
                    {
                        if (theForceDiaries.ContainsKey(forceSide) == false)
                        {
                            theForceDiaries.Add(forceSide, new List<string>());
                            if (theForceDiaries[forceSide].Contains(forceUser) == false)
                            {
                                theForceDiaries[forceSide].Add(forceUser);
                            }
                        }
                        else
                        {
                            if (theForceDiaries[forceSide].Contains(forceUser) == false)
                            {
                                theForceDiaries[forceSide].Add(forceUser);
                            }

                        }
                    }
                    

                }
                else if (separator == "->")
                {
                    forceUser = match.Groups["leftPart"].Value;
                    forceSide = match.Groups["rightPart"].Value;

                    foreach (var item in theForceDiaries.Values)
                    {
                        if (item.Contains(forceUser))
                        {
                            IsContained = true;
                            item.Remove(forceUser);
                        }
                    }

                    if (theForceDiaries.ContainsKey(forceSide) == false)
                    {
                        if (IsContained == false)
                        {
                            theForceDiaries.Add(forceSide, new List<string>());
                            theForceDiaries[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                        else
                        {
                            theForceDiaries[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                    else
                    {
                        if (IsContained == false)
                        {
                            theForceDiaries[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                        else
                        {
                            theForceDiaries[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }

                }
                


                command = Console.ReadLine();
            }

            foreach (var kvp in theForceDiaries.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                    foreach (string item in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
            }
        }
    }
}
