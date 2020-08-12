using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> concertInfo
                = new Dictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                Regex regex 
                    = new Regex(@"(?<singer>[A-Za-z ]*) @(?<venue>[a-zA-Z ]+) (?<price>\d+) (?<count>\d+)");
                bool isValid = regex.IsMatch(input);
                if (isValid == false)
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    Match match = regex.Match(input);
                    string singer = match.Groups["singer"].Value;
                    string venue = match.Groups["venue"].Value;
                    int ticketPrice = int.Parse(match.Groups["price"].Value);
                    int ticketCount = int.Parse(match.Groups["count"].Value);
                    int income = ticketCount * ticketPrice;

                    if (concertInfo.ContainsKey(venue) == false)
                    {
                        concertInfo.Add(venue, new Dictionary<string, int>());
                        concertInfo[venue].Add(singer, income);
                    }
                    else
                    {
                        if (concertInfo[venue].ContainsKey(singer) == false)
                        {
                            concertInfo[venue].Add(singer, income);
                        }
                        else
                        {
                            concertInfo[venue][singer] += income;
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var venueDictPair in concertInfo)
            {
                Console.WriteLine($"{venueDictPair.Key}");
                foreach (var innerPair in venueDictPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {innerPair.Key} -> {innerPair.Value}");
                }
            }
        }
    }
}
