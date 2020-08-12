using System;

namespace _07cake_ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;

            while (true)
            {
                string ingridient = Console.ReadLine();
                if (ingridient.Equals("Bake!"))
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
                count++;
                Console.WriteLine($"Adding ingredient {ingridient}.");
            }
        }
    }
}
