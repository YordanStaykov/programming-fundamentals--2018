using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04annonymous_cache
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 13 ,4, 48 };
            nums.Reverse();
            Console.WriteLine(string.Join(" ! ",nums));

            Dictionary<int, string> dicky = new Dictionary<int, string>();
            dicky[1] = "dani";
            dicky[2] = "pony";
            dicky[3] = "pony";

            Dictionary<int, string> sortedDicky = dicky
                .OrderBy(pair => pair.Value)
                .ThenByDescending(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in sortedDicky)
            {
                Console.WriteLine("{0} => {1}", pair.Key , pair.Value);
            }

            string dateText = "15-08-2017";
            DateTime date = DateTime.ParseExact(dateText, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            TimeSpan span = date.Subtract(DateTime.Now);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(span);
            Console.WriteLine(date);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = DateTime.Now.AddDays(12).AddMinutes(30);
            Console.WriteLine(tomorrow);

            Dankera firstDanker = new Dankera() { hairColour = "red", age = 26 };
            Console.WriteLine(firstDanker.age);

            string kon = "kon";
            string konche = "Kon";

            int compare = string.Compare(konche, kon, true);
            Console.WriteLine(compare);


            string cool = "dankera e mnogo mnogo gotin";
            int firstIndex = cool.IndexOf("mnogo", 13);
            Console.WriteLine(firstIndex);
        }

        class Dankera
        {
            public string hairColour;
            public int age;
        }
    }
}
