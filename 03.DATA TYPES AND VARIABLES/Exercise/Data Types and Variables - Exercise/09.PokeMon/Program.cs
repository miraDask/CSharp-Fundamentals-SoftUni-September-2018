using System;

namespace _09.PokeMon
{
    public class Program
    {
        public static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            int originalPower = power;

            while (power >= distance)
            {
                power -= distance;
                counter++;

                if ((power == originalPower / 2) && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
