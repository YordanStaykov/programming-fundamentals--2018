using System;

namespace _18differnt_integers_size
{
    class Program
    {
        static void Main(string[] args)
        {
            string numb = Console.ReadLine();
            string message = "";
            bool isTrue = false;

            try
            {
                sbyte number = sbyte.Parse(numb);
                message += "* sbyte\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                byte number = byte.Parse(numb);
                message += "* byte\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                short number = short.Parse(numb);
                message += "* short\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                ushort number = ushort.Parse(numb);
                message += "* ushort\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                int number = int.Parse(numb);
                message += "* int\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                uint number = uint.Parse(numb);
                message += "* uint\r\n";
                isTrue = true;
            }
            catch { }
            try
            {
                long number = long.Parse(numb);
                message += "* long\r\n";
                isTrue = true;
            }
            catch { }

            if (isTrue)
            {
                Console.WriteLine($"{numb} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{numb} can't fit in any type");
            }

        }
    }
}
