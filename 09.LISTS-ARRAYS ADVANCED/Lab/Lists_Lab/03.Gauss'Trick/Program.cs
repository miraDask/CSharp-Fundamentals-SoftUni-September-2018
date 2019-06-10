namespace _03.Gauss_Trick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int limit = numbers.Count / 2;

            for (int i = 0; i < limit; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1 - i];

            }

            if (numbers.Count % 2 == 0)
            {
                numbers.RemoveRange(limit, limit);
            }
            else
            {
                numbers.RemoveRange(limit + 1, limit);
            }


            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
