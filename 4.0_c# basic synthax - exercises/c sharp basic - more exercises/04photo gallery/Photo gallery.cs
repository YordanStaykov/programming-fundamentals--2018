using System;

namespace _04photo_gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes  = int.Parse(Console.ReadLine());
            double sizeInBytes  = double.Parse(Console.ReadLine());
            int width  = int.Parse(Console.ReadLine());
            int height  = int.Parse(Console.ReadLine());

            double picSize = 0;
            string picSizeFormat = "";
            if (sizeInBytes >= 1000000)
            {
                picSize = sizeInBytes / 1000000;
                picSizeFormat = "MB";
            }
            else if (sizeInBytes >= 1000)
            {
                picSize = sizeInBytes / 1000;
                picSizeFormat = "KB";
            }
            else
            {
                picSize = sizeInBytes;
                picSizeFormat = "B";
            }

            string orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";

            }
            else
            {
                orientation = "square";
            }


            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {picSize}{picSizeFormat}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
