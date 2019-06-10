

namespace _01DayOfWeek
{
    using System;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
