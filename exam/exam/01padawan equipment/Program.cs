using System;

namespace _01padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialMoney = double.Parse(Console.ReadLine());
            double studenstCount = double.Parse(Console.ReadLine());
            double lightsabresPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabresTotalPrice = lightsabresPrice
                * ((studenstCount + Math.Ceiling(studenstCount * 0.1)));
            double robeTotalPrice = studenstCount * robesPrice;
            double beltsTotalPrice = 0.0;

            for (int i = 1; i <= studenstCount; i++)
            {
                if (i % 6 == 0)
                {
                    continue;
                }
                beltsTotalPrice += beltsPrice;
            }

            double totalEquipmentCost = lightsabresTotalPrice + robeTotalPrice + beltsTotalPrice;
            double diff = Math.Abs(totalEquipmentCost - initialMoney);

            if (initialMoney >= totalEquipmentCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {diff:F2}lv more.");
            }


        }
    }
}
