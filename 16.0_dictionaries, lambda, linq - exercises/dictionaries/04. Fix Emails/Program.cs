using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> personalInfo = new Dictionary<string, string>();

            

            while (true)
            {
                string name = Console.ReadLine();
                if (name.Equals("stop"))
                {
                    break;
                }
                string email = Console.ReadLine();

                string[] emailArr = email.Split('.').Reverse().ToArray();
                if ((emailArr[0].Equals("us") || emailArr[0].Equals("uk")) == false)
                {
                    personalInfo.Add(name, email);
                }

            }

            foreach (var infoPair in personalInfo)
            {
                Console.WriteLine($"{infoPair.Key} -> {infoPair.Value}");
            }
        }
    }
}
