

namespace _01.Train
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numOfWagons = int.Parse(Console.ReadLine());

            int[] train = new int[numOfWagons];

            int sumOfPeople = 0;

            for (int i = 0; i < train.Length; i++)
            {
                int peoples = int.Parse(Console.ReadLine());

                train[i] = peoples;
                sumOfPeople += peoples;
            }

            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(sumOfPeople);
        }
    }
}
