using System;
using System.Collections.Generic;

namespace _04._Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productInput = Console.ReadLine().Split();
            Dictionary<string, double[]> bevarages = new Dictionary<string, double[]>();

            while (productInput[0] != "stocked")
            {
                string drink = productInput[0];
                double price = double.Parse(productInput[1]);
                int quantity = int.Parse(productInput[2]);

                double[] priceQuantity = new double[2];

                if (bevarages.ContainsKey(drink) == false)
                {
                    bevarages.Add(drink, priceQuantity);
                    priceQuantity[0] = price;
                    priceQuantity[1] += quantity;
                }
                else
                {
                    bevarages[drink][0] = price;
                    bevarages[drink][1] += quantity;
                }
                

                productInput = Console.ReadLine().Split();
            }

            foreach (var pair in bevarages)
            {
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}"
                    ,pair.Key, pair.Value[0], pair.Value[1], (pair.Value[0] * pair.Value[1]));
            }

            Console.WriteLine(new string('-',30));

            double grandTotal = 0;
            foreach (var pair in bevarages)
            {
                grandTotal += pair.Value[0] * pair.Value[1];
            }

            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
