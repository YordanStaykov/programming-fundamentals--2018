using System;

namespace _03back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                minutes = minutes % 60;
                hours++;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            //  if (minutes >= 60)
            //  {
            //      hours++;
            //      minutes -= 60;
            //  }
            //  if (hours > 23)
            //  {
            //      hours -= 24;
            //  }


            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
