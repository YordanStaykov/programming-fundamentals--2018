﻿using System;

namespace _14integer_to_hex_and_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string hexa = Convert.ToString(num, 16).ToUpper();
            string binary = Convert.ToString(num, 2);

            Console.WriteLine(hexa);
            Console.WriteLine(binary);
        }
    }
}
