using System;

namespace _09._PadawanEquipment
{
    public class Program
    {
        public static void Main()
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice= double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelts = students / 6;

            double sabreCount = Math.Ceiling(students * 1.1);
            double equipmentPrice = (robePrice * students) + (sabrePrice * (int)sabreCount) + (beltPrice * (students - freeBelts))  ;


            if (equipmentPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(equipmentPrice - budget):f2}lv more.");
            }

        }
    }
}
