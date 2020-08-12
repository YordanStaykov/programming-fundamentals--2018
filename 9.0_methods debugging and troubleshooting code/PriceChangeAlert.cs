using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numb = int.Parse(Console.ReadLine());



        double treshold = double.Parse(Console.ReadLine());


        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = CalculateDifference(previousPrice, currentPrice);
            bool isSignificantDifference = IsThereDiffenrece(difference, treshold);



            string message = GetalertMessage(currentPrice, previousPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            previousPrice = currentPrice;
        }
    }

    private static string GetalertMessage(double currentPrice, double previousPrice, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference);
            return message;
        }
    }

    private static bool IsThereDiffenrece(double difference, double treshold)
    {
        if (Math.Abs(treshold) >= difference)
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
