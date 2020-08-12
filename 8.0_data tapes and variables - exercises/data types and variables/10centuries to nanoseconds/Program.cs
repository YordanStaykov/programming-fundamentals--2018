﻿using System;

namespace _10centuries_to_nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            int minutes = hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days" +
                $" = {hours} hours = {minutes} minutes = {seconds} seconds" +
                $" = {milliseconds} milliseconds = {microseconds} microseconds" +
                $" = {nanoseconds} nanoseconds");
        }
    }
}
