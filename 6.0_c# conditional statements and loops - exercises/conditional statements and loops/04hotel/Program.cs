using System;

namespace _04hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            int stuidioPrice = 0;
            int doublePrice = 0;
            int suitePrice = 0;
            double studioDiscount = 0;
            double douleDiscount = 0;
            double suiteDiscount = 0;
            int studioNightsCount = nightsCount;

            switch (months)
            {
                case "May":
                case "October":
                    stuidioPrice = 50;
                    if (nightsCount > 7)
                    {
                        studioDiscount = 0.05;
                    }
                    doublePrice = 65;
                    suitePrice = 75;
                    break;
                case "June":
                case "September":
                    stuidioPrice = 60;
                    doublePrice = 72;
                    if (nightsCount > 14)
                    {
                        douleDiscount = 0.1;
                    }
                    suitePrice = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    stuidioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightsCount > 14)
                    {
                        suiteDiscount = 0.15;
                    }
                    break;
                   
            }
            if (months.Equals("September") || months.Equals("October") && nightsCount > 7)
            {
                studioNightsCount = nightsCount - 1;
            }


            double studioTotalPrice = 0;
            double doubleTotalPrice = 0;
            double suiteTotalPrice = 0;


            if (studioDiscount != 0)
            {

                 studioTotalPrice = (stuidioPrice * studioNightsCount) - ((stuidioPrice * studioNightsCount) * studioDiscount);
            }
            else
            {
                 studioTotalPrice = (stuidioPrice * studioNightsCount);
            }

            if (douleDiscount != 0)
            {
                 doubleTotalPrice = (doublePrice * nightsCount) - ((doublePrice * nightsCount) * douleDiscount);
            }
            else
            {
                 doubleTotalPrice = (doublePrice * nightsCount);
            }

            if (suiteDiscount != 0)
            {
                suiteTotalPrice = (suitePrice * nightsCount) - ((suitePrice * nightsCount) * suiteDiscount);
            }
            else
            {
                suiteTotalPrice = (suitePrice * nightsCount);
            }
            

            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.\r\nDouble: {doubleTotalPrice:F2} lv.\r\nSuite: {suiteTotalPrice:F2} lv.");

        }
    }
}
