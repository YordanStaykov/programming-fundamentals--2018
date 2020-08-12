using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            string[] row = Console.ReadLine().Split(new char[] { ':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int sum = 0;
            string playerName = "";
            List<string> cards = new List<string>();

            while (row[0] != "JOKER")
            {
                playerName = row[0];
                cards = row[1].Split(new char[] {',', ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                cards = cards.Distinct().ToList();

                if (players.ContainsKey(playerName) == false)
                {
                    players[playerName] = cards;
                }
                else
                {
                    players[playerName].AddRange(cards);
                    players[playerName] = players[playerName].Distinct().ToList();
                }

                row = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            int type = 0;
            int power = 0;
            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            type = 4;
                            break;
                        case 'H':
                            type = 3;
                            break;
                        case 'D':
                            type = 2;
                            break;
                        case 'C':
                            type = 1;
                            break;
                    }

                    string newCard = card.Remove(card.Length - 1, 1);

                    switch (newCard)
                    {
                        case "A":
                            power = 14;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "J":
                            power = 11;
                            break;
                        default:
                            power = int.Parse(newCard);
                            break;
                          
                    }

                    sum += power * type;
                }
                Console.WriteLine($"{player.Key}: {sum}");
                sum = 0;
            }


        }
    }
}
