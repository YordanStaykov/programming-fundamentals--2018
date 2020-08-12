using System;

namespace _04variable_in_hex_format
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInString = Console.ReadLine();
     
            int numInInt = Convert.ToInt32(numInString, 16);
          
            Console.WriteLine(numInInt);
            
        }
    }
}
