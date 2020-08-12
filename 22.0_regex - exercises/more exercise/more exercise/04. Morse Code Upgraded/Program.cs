using System;
using System.Linq;

namespace _04._Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split('|');

            foreach (string number in numbers)
            {
                //111000001110000
                int sum = 0;                
                for (int i = 0; i < number.Length; i++)
                {
                    int digit = int.Parse(number[i].ToString());
                    if (digit == 0)
                    {
                        sum += 3;
                    }
                    else
                    { 
                        sum += 5;
                    }


                }

                char letter = Convert.ToChar(sum);
                Console.WriteLine(letter);
            }
        }
    }
}



