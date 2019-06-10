using System;

namespace _03.TownInfo
{
    public class Program
    {
        public static void Main()
        {
            string town = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
