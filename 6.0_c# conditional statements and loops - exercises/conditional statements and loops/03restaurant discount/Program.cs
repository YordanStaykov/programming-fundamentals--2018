using System;

namespace _03restaurant_discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallType = "";
            int hallPrice = 0;
            double packageDiscount = 0;
            double packagePrice = 0;

            if (groupSize <= 50)
            {
                hallType = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallType = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallType = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    packageDiscount = 0.05;
                    break;
                case "Gold":
                    packagePrice = 750;
                    packageDiscount = 0.10;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    packageDiscount = 0.15;
                    break;
            }

            double totalPrice = hallPrice + packagePrice;
            double totalPriceAfterDiscount = totalPrice - (totalPrice * packageDiscount);
            double pricePerPerson = totalPriceAfterDiscount / groupSize;

            Console.WriteLine($"We can offer you the {hallType}\r\nThe price per person is {pricePerPerson:f2}$");
        }
    }
}
