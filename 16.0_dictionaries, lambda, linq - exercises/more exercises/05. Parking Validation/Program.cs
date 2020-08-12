using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingData = new Dictionary<string, string>();


            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string operation = commands[0];
                string username = commands[1];


                if (operation == "register")
                {

                    string licencePlate = commands[2];

                    if (parkingData.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingData[username]}");
                    }
                    else
                    {
                        if (IsValid(licencePlate))
                        {
                            if (parkingData.ContainsValue(licencePlate))
                            {
                                Console.WriteLine($"ERROR: license plate {licencePlate} is busy");
                            }
                            else
                            {
                                parkingData.Add(username, licencePlate);
                                Console.WriteLine($"{username} registered {licencePlate} successfully");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licencePlate}");
                        }
                    }

                }
                else if (operation == "unregister")
                {
                    if (parkingData.ContainsKey(username))
                    {
                        parkingData.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }


            }

            foreach (var pair in parkingData)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }


        }

        static bool IsValid(string licencePlate)
        {
            char[] leftPart = licencePlate.Take(2).ToArray();
            char[] rightPart = licencePlate.Skip(6).Take(2).ToArray();
            char[] leftRightPart = leftPart.Concat(rightPart).ToArray();
            char[] middlePart = licencePlate.Skip(2).Take(4).ToArray();

            foreach (char letter in leftRightPart)
            {
                if (letter < 65 || letter > 90)
                {
                    return false;

                }
            }

            foreach (char number in middlePart)
            {
                if (number < 48 || number > 57)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

