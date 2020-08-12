using System;
using System.Text.RegularExpressions;

namespace _03.Snowfalke
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex surface = new Regex(@"^[^A-Za-z0-9]+$");
            Regex mantle = new Regex(@"^[0-9_]+$");
            Regex middleLine = new Regex(@"^[^A-Za-z0-9]+[0-9_]+([a-zA-Z]+)[0-9_]+[^A-Za-z0-9]+$");
            int length = 0;

            for (int row = 0; row < 5; row++)
            {
                string line = Console.ReadLine();
                if (row == 0 || row == 4)
                {
                    if (surface.IsMatch(line) == false)
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else if (row == 1 || row == 3)
                {
                    if (mantle.IsMatch(line) == false)
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else
                {
                    if (middleLine.IsMatch(line) == false)
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                    else
                    {
                        Match coreMatch = middleLine.Match(line);
                        length = coreMatch.Groups[1].Value.Length;
                    }
                }
            }

            Console.WriteLine("Valid");
            Console.WriteLine(length);
        }
    }
}
