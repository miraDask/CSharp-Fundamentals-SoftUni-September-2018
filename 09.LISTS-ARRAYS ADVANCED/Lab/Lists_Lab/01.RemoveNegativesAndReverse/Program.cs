namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n > 0)
                .Reverse()
                .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
            Console.WriteLine(string.Join(" ",numbers));

            }
        }
    }
}
