using System;

namespace _02choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            string drink = "";

            switch (proffession)
            {
                case "Athlete":
                    drink = "Water";
                    totalPrice = quantity * 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    totalPrice = quantity;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    totalPrice = quantity * 1.70;
                    break;
                default:
                    drink = "Tea";
                    totalPrice = quantity * 1.2;
                    break;

            }
            Console.WriteLine($"The {proffession} has to pay {totalPrice:f2}.");
        }
    }
}
