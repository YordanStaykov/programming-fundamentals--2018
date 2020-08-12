using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int logs = int.Parse(Console.ReadLine());
            var usersLog = new SortedDictionary<string, SortedDictionary<string, int>>();

            string ip = "";
            string username = "";
            int duration = 0;
            

            for (int i = 0; i < logs; i++)
            {
                string[] userInfo = Console.ReadLine().Split().ToArray();
                ip = userInfo[0];
                username = userInfo[1];
                duration = int.Parse(userInfo[2]);

                if (usersLog.ContainsKey(username) == false)
                {
                    usersLog.Add(username, new SortedDictionary<string, int>());
                }
                if (usersLog[username].ContainsKey(ip) == false)
                {
                    usersLog[username].Add(ip, duration);
                }
                else
                {
                    usersLog[username][ip] += duration;
                }
            }


            foreach (var user in usersLog)
            {
                var totalDurationOfUser = usersLog[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
