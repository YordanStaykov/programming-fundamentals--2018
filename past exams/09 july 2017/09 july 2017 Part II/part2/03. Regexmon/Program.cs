using System;
using System.Text.RegularExpressions;

namespace _03._Regexmon
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";
            string didiPattern = @"[^A-Za-z-]+";
            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    if (Regex.IsMatch(text,didiPattern) == false)
                    {
                        return;
                    }
                    else
                    {
                        Match didiMatch = Regex.Match(text, didiPattern);
                        Console.WriteLine(didiMatch.Value);
                        text = text.Substring(didiMatch.Index + didiMatch.Length);
                    }
                }
                else
                {
                    if (Regex.IsMatch(text, bojoPattern) == false)
                    {
                        return;
                    }
                    else
                    {
                        Match bojosMatch = Regex.Match(text, bojoPattern);
                        Console.WriteLine(bojosMatch.Value);
                        text = text.Substring(bojosMatch.Index + bojosMatch.Length);
                    }
                }
                round++;
            }


        }
    }
}
