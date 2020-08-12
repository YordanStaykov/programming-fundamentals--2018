using System;

namespace _09refacctor_special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numb; i++)
            {
                
            int sumOfDigits = 0;
            int digits = i;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {special}");
                
            }

        }
    }
}
