using System;
using System.Collections.Generic;
using System.Linq;

namespace _02softUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            List<string> availableSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            Dictionary<string, List<string>> competetors = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "dawn")
            {
                string[] performance = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string participant = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (participant.Contains(participant) && availableSongs.Contains(song))
                {
                    if (competetors.ContainsKey(participant) == false)
                    {
                        competetors.Add(participant, new List<string>());
                    }
                    else
                    {
                        competetors[participant].Add(award);
                    }      
                }

                input = Console.ReadLine();


            }

            if (competetors.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var performerAwardsPair in competetors.OrderByDescending(x => x.Value.Distinct().ToList().Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{performerAwardsPair.Key}: {performerAwardsPair.Value.Count()} awards");
                List<string> awards = performerAwardsPair.Value.Distinct().ToList();
                foreach (var award in awards.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }


        }
    }
}
