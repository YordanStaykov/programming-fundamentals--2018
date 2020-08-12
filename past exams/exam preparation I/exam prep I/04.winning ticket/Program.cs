using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.winning_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',' }).Select(x => x.Trim()).ToArray();
            Regex monkeyA = new Regex(@"@{6,10}");
            Regex diez = new Regex(@"#{6,10}");
            Regex dollarSign = new Regex(@"\${6,10}");
            Regex chavka = new Regex(@"\^{6,10}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftSide = ticket.Substring(0, 10);
                    string rightSide = ticket.Substring(10);

                    if (monkeyA.IsMatch(leftSide) && monkeyA.IsMatch(rightSide))
                    {
                        Match matchLeft = monkeyA.Match(leftSide);
                        Match matchRight = monkeyA.Match(rightSide);
                        if (matchLeft.Length > 5 && matchLeft.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}@");
                        }
                        if (matchLeft.Length == 10 && matchRight.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}@ Jackpot!");
                        }
                    }else if (diez.IsMatch(leftSide) && diez.IsMatch(rightSide))
                    {
                        Match matchLeft = diez.Match(leftSide);
                        Match matchRight = diez.Match(rightSide);
                        if (matchLeft.Length > 5 && matchLeft.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}#");
                        }
                        if (matchLeft.Length == 10 && matchRight.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}# Jackpot!");
                        }
                    }
                    else if (dollarSign.IsMatch(leftSide) && dollarSign.IsMatch(rightSide))
                    {
                        Match matchLeft = dollarSign.Match(leftSide);
                        Match matchRight = dollarSign.Match(rightSide);
                        if (matchLeft.Length > 5 && matchLeft.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}$");
                        }
                        if (matchLeft.Length == 10 && matchRight.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}$ Jackpot!");
                        }
                    } else if (chavka.IsMatch(leftSide) && chavka.IsMatch(rightSide))
                    {
                        Match matchLeft = chavka.Match(leftSide);
                        Match matchRight = chavka.Match(rightSide);
                        if (matchLeft.Length > 5 && matchLeft.Length < 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}^");
                        }
                        if (matchLeft.Length == 10 && matchRight.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {matchLeft.Length}^ Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
