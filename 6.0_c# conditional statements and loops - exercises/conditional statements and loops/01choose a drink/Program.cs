using System;

namespace _01choose_a_drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            string drink = "";

            switch (proffession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
               
            }
            Console.WriteLine(drink);
        }
    }
}
