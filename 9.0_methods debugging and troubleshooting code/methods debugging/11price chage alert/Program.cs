using System;

namespace _11price_chage_alert
{
    class Program
    {
        static void Main()
        {
            int numb = int.Parse(Console.ReadLine());



            double treshold = double.Parse(Console.ReadLine());


            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numb - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = CalculateDifference(previousPrice, currentPrice);
                bool isSignificantDifference = IsThereDiffenrece(difference, treshold);



                string message = GetAlertMessage(currentPrice, previousPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        static string GetAlertMessage(double currentPrice, double previousPrice, double difference, bool isSignificantDifference)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
                return message;
        }

        private static bool IsThereDiffenrece(double difference, double treshold)
        {
            if (Math.Abs(treshold) <= Math.Abs(difference))
            {
                return true;
            }
            return false;
        }

        private static double CalculateDifference(double previousPrice, double currentPrice)
        {
            return (currentPrice - previousPrice) / previousPrice;
        }
    }
}
