using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03star_enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageCount = int.Parse(Console.ReadLine());
            List<string> messages = new List<string>();
            string decryptedMessage = "";
            
            for (int i = 0; i < messageCount; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int key = 0;
                decryptedMessage = "";
                for (int k = 0; k < encryptedMessage.Length; k++)
                {
                    if (encryptedMessage[k] == 's' || encryptedMessage[k] == 't' 
                        || encryptedMessage[k] == 'a' || encryptedMessage[k] == 'r'
                        ||encryptedMessage[k] == 'S' || encryptedMessage[k] == 'T'
                        || encryptedMessage[k] == 'A' || encryptedMessage[k] == 'R')
                    {
                        key++;
                    }
                }
                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    decryptedMessage += Convert.ToChar(encryptedMessage[j] - key);
                }

                messages.Add(decryptedMessage);
            }

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            foreach (var mess in messages)
            {
                Regex regex = new Regex(@"@(?<planet>[A-Za-z]+)([^@\-!:>]+)*:(?<population>[0-9]+)([^@\-!:>]+)*!(?<attackType>[AD])!([^@\-!:>]+)*->(?<soldierCount>[0-9]+)");

                if (regex.IsMatch(mess))
                {
                    Match match = regex.Match(mess);
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attackType"].Value;
                    if (attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                    else 
                    {
                        attackedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
