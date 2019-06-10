using System;

namespace _05.MonthPrinter
{
    public class Program
    {
        public static void Main()
        {
            int numOfMonth = int.Parse(Console.ReadLine());

            string[] year = {  "January", "February", "March", "April", "May", "June", "July", "August","September", "October", "November", "December" };


            if (numOfMonth > 12 || numOfMonth < 1)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(year[numOfMonth - 1]);

            }
        }
    }
}
