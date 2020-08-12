using System;

namespace _08calories_couter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsCount = int.Parse(Console.ReadLine());
            int sumCalories = 0;
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;

            for (int i = 0; i < ingredientsCount; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient.Equals("cheese"))
                {
                    sumCalories += cheese;
                }
                else if (ingredient.Equals("tomato sauce"))
                {
                    sumCalories += tomatoSauce;
                }
                else if (ingredient.Equals("salami"))
                {
                    sumCalories += salami;
                }
                else if (ingredient.Equals("pepper"))
                {
                    sumCalories += pepper;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine($"Total calories: {sumCalories}");
        }
    }
}
