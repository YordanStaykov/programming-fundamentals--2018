using System;

namespace _02vapor_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string videoGame = "";
            double outFall4 = 39.99;
            double csOG = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOrigins = 39.99;
            double totalSpent = 0;

            while (currentBalance > 0)
            {
                videoGame = Console.ReadLine();
                switch (videoGame)
                {
                    case "OutFall 4":
                        if (currentBalance >= outFall4)
                        {
                            currentBalance -= outFall4;
                            totalSpent += outFall4;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (currentBalance >= csOG)
                        {
                            currentBalance -= csOG;
                            totalSpent += csOG;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance >= zplinterZell)
                        {
                            currentBalance -= zplinterZell;
                            totalSpent += zplinterZell;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance >= honored2)
                        {
                            currentBalance -= honored2;
                            totalSpent += honored2;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= roverWatchOrigins)
                        {
                            currentBalance -= roverWatchOrigins;
                            totalSpent += roverWatchOrigins;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance >= roverWatch)
                        {
                            currentBalance -= roverWatch;
                            totalSpent += roverWatch;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
                        return;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
            }
            Console.WriteLine("Out of money!");
          
        }
    }
}
