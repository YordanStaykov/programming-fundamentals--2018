using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool shadowmourneObtained = false;
            bool valanyrObtained = false;
            bool dragonwratheObtained = false;
            string material = "";
            int quantity = 0;
            string reward = "";

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();


            while (shadowmourneObtained == false && valanyrObtained == false && dragonwratheObtained == false)
            {

                string[] materialInput = Console.ReadLine().ToLower().Split().ToArray();
                for (int i = 0; i < materialInput.Length; i += 2)
                {
                    quantity = int.Parse(materialInput[i]);
                    material = materialInput[i + 1];

                    switch (material)
                    {
                        case "shards":
                            keyMaterials[material] += quantity;
                            break;


                        case "fragments":
                                keyMaterials[material] += quantity;
                            break;


                        case "motes":
                                keyMaterials[material] += quantity;
                            break;


                        default:
                            if (junkMaterials.ContainsKey(material) == false)
                            {
                                junkMaterials.Add(material, quantity);
                            }
                            else
                            {
                                junkMaterials[material] += quantity;
                            }
                            break;

                    }
                    if (keyMaterials.ContainsKey("shards"))
                    {
                        if (keyMaterials["shards"] >= 250)
                        {
                            shadowmourneObtained = true;
                            reward = "Shadowmourne obtained!";
                            keyMaterials["shards"] -= 250;
                            break;
                        }
                    }
                    if (keyMaterials.ContainsKey("fragments"))
                    {

                        if (keyMaterials["fragments"] >= 250)
                        {
                            valanyrObtained = true;
                            reward = "Valanyr obtained!";
                            keyMaterials["fragments"] -= 250;
                            break;
                        }
                    }

                    if (keyMaterials.ContainsKey("motes"))
                    {
                        if (keyMaterials["motes"] >= 250)
                        {
                            dragonwratheObtained = true;
                            reward = "Dragonwrath obtained!";
                            keyMaterials["motes"] -= 250;
                            break;
                        }
                    }

                }

               
            }

            Console.WriteLine(reward);
            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
