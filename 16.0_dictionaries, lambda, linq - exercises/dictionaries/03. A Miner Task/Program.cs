using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
  
            Dictionary<string, int> totalResource = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());


                if (totalResource.ContainsKey(resource))
                {
                    totalResource[resource] += quantity;
                }
                else
                {
                    totalResource.Add(resource, quantity);
                }


            }

            foreach (var resQuantPair in totalResource)
            {
                Console.WriteLine($"{resQuantPair.Key} -> {resQuantPair.Value}");
            }
        }
    }
}
