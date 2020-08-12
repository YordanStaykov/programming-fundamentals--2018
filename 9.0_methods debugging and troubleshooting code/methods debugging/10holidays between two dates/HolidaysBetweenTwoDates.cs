using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string start = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(start,
            "d.M.yyyy", CultureInfo.InvariantCulture);
        string end = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(end,
            "d.M.yyyy", CultureInfo.InvariantCulture);
        int holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        Console.WriteLine(holidaysCount);
    }
}
