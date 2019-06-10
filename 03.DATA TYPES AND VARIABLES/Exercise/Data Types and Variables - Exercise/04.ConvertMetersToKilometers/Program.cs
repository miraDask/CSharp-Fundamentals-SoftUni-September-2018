using System;

namespace _04.ConvertMetersToKilometers
{
    public class Program
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double distanceInKilometers = distanceInMeters / 1000.0;

            Console.WriteLine("{0:f2}",distanceInKilometers);
        }
    }
}
