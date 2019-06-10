using System;

namespace _04.Back_in_30_Minutes
{
    public class Program
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allInMins = (hours * 60) + minutes + 30;

            int newHours = allInMins / 60;
            int newMins = allInMins % 60;

            if (newHours > 23)
            {
                newHours = 0;
            }
            if (newMins < 10)
            {
                Console.WriteLine($"{newHours}:{newMins:d2}");
            }
            else
            {

                Console.WriteLine($"{newHours}:{newMins}");

            }
        }
    }
}
