using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            string city = "";
            string country = "";
            long population = 0;

            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                city = input[0];
                country = input[1];
                population = long.Parse(input[2]);

                if (countries.ContainsKey(country) == false)
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);

                }
                else
                {

                    countries[country].Add(city, population);

                }

                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var pair in countries.OrderByDescending(s => s.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}
