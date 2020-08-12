using System;

namespace _07training_hall_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subTotal = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }

                subTotal += itemPrice * itemCount;
            }

            double moneyLeft = Math.Abs(subTotal - budget);
            Console.WriteLine($"Subtotal: ${subTotal:F2}");
            if (subTotal <= budget)
            {
                Console.WriteLine($"Money left: ${moneyLeft:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${moneyLeft:F2} more.");
            }
        }
    }
}
