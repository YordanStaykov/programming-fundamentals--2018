using System;

namespace _08greater_of_two_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            switch (inputType)
            {
                case "int" :
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int greaterOfTwoInts = GetGreaterInt(firstInt, secondInt);
                    Console.WriteLine(greaterOfTwoInts);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char greaterOfTwoChars = GetGreaterChar(firstChar, secondChar);
                    Console.WriteLine(greaterOfTwoChars);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string greaterOfTwoStrings = GetGreaterString(firstString, secondString);
                    Console.WriteLine(greaterOfTwoStrings);
                    break;
            }
        }

        static int GetGreaterInt(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetGreaterChar(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetGreaterString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
