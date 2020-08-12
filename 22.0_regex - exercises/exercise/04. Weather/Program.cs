using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string text = "";
            while (data != "end")
            {
                text += data + "\r\n";
                data = Console.ReadLine();
            }

            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+.\d+)(?<weather>[a-zA-Z]+)\|";
            MatchCollection matches = Regex.Matches(text, pattern);
            Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>();

            foreach (Match match in matches)
            {
                string city = match.Groups["city"].Value;
                string temp = match.Groups["temp"].Value;
                string weather = match.Groups["weather"].Value;
                

                if (cities.ContainsKey(city) == false)
                {
                    List<string> tempWeather = new List<string>();
                    cities.Add(city, tempWeather);
                    cities[city].Add(temp);
                    cities[city].Add(weather);
                }
                else
                {
                    cities[city].Clear();
                    cities[city].Add(temp);
                    cities[city].Add(weather);
                }
            }
            foreach (var pair in cities.OrderBy(x => x.Value[0]))
            {
                double temp = double.Parse(pair.Value[0]);
                Console.WriteLine($"{pair.Key} => {temp:F2} => {pair.Value[1]}");
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//namespace _04._Weather
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string data = Console.ReadLine();
//            string text = "";
//            while (data != "end")
//            {
//                text += data + "\r\n";
//                data = Console.ReadLine();
//            }

//            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+.\d+)(?<weather>[a-zA-Z]+)\|";
//            MatchCollection matches = Regex.Matches(text, pattern);
//            Dictionary<string, string[]> cities = new Dictionary<string, string[]>();

//            foreach (Match match in matches)
//            {
//                string city = match.Groups["city"].Value;
//                string temp = match.Groups["temp"].Value;
//                string weather = match.Groups["weather"].Value;

//                if (cities.ContainsKey(city) == false)
//                {
//                    string[] tempWeather = new string[2];
//                    cities.Add(city, tempWeather);
//                    cities[city][0] = temp;
//                    cities[city][1] = weather;
//                }
//                else
//                {
//                    cities[city][0] = temp;
//                    cities[city][1] = weather;
//                }
//            }
//            foreach (var pair in cities.OrderBy(x => x.Value[0]))
//            {
//                double temp = double.Parse(pair.Value[0]);
//                Console.WriteLine($"{pair.Key} => {temp:F2} => {pair.Value[1]}");
//            }
//        }
//    }
//}
