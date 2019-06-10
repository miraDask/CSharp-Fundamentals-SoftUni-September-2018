using System;

namespace _02.Passed
{
    public class Program
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
