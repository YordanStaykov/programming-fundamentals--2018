using System;
using System.IO;
using System.Text;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sb.AppendLine(lines[i]);
                }
            }

            File.WriteAllText("output.txt", sb.ToString());
        }
    }
}
