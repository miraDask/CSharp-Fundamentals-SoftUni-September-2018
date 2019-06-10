using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int cources = (int)Math.Ceiling(numOfPeople / (double)capacity);
            Console.WriteLine(cources);
        }
    }
}
