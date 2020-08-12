using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int siteCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalMoneyLoss  = 0;
            List<string> siteArr = new List<string>();

            for (int i = 0; i < siteCount; i++)
            {
                string[] siteInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = siteInfo[0];
                decimal siteVisits = decimal.Parse(siteInfo[1]);
                decimal pricePerVisit = decimal.Parse(siteInfo[2]);
                siteArr.Add(siteName);

                decimal siteLoss = siteVisits * pricePerVisit;
                totalMoneyLoss += siteLoss;
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, siteCount);
            Console.WriteLine(string.Join(Environment.NewLine, siteArr));
            Console.WriteLine($"Total Loss: {totalMoneyLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}
