using System;

namespace _04bevarage_labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent100ml = double.Parse(Console.ReadLine());
            double sugarContent100ml = double.Parse(Console.ReadLine());
            double energyContent = energyContent100ml * volume / 100;
            double sugarContent = sugarContent100ml * volume / 100;
            Console.WriteLine($"{volume}ml {name}:\n{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
