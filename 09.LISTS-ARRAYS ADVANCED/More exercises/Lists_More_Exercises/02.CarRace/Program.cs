
namespace _02.CarRace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int splitIndex = input.Length / 2;

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < splitIndex; i++)
            {

                if (input[i] != 0)
                {
                    leftRacerTime += input[i];
                }
                else
                {
                    leftRacerTime *= 0.8;
                }
            }
            for (int i = input.Length - 1; i >= splitIndex + 1; i--)
            {

                if (input[i] != 0)
                {
                    rightRacerTime += input[i];
                }
                else
                {
                    rightRacerTime *= 0.8;
                }
            }


            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else if (rightRacerTime < leftRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
    }
}
