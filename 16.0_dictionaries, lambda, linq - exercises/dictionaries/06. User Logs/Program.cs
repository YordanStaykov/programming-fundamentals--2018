using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split().ToArray();
            string ip = "";
            string user = "";

            Dictionary<string, Dictionary<string, int>> site = new Dictionary<string, Dictionary<string, int>>();

            while (commands[0] != "end")
            {
                ip = commands[0].Remove(0, 3);
                user = commands[2].Remove(0, 5);

                if (site.ContainsKey(user) == false)
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    site.Add(user, current);
                }
                else
                {
                    if (site[user].ContainsKey(ip) == false)
                    {
                        site[user].Add(ip, 1);
                    }
                    else
                    {
                        site[user][ip]++;
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }

            foreach (var currentUser in site.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{currentUser.Key}: ");
                List<string> helper = new List<string>();
                foreach (var ipPair in currentUser.Value)
                {
                    helper.Add($"{ipPair.Key} => {ipPair.Value}");
                }
            Console.WriteLine(string.Join(", ",helper) + ".");
            }

        }
    }
}
