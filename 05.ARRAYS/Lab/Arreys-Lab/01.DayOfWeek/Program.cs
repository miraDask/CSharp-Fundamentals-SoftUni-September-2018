

namespace _01.DayOfWeek
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
