
namespace _04.Largest3Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sorted = numbers.OrderByDescending(x => x).ToArray();

            string result = " ";

            if (sorted.Length < 3)
            {
                Console.WriteLine(string.Join(" ", sorted));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    result += sorted[i] + " ";
                }

                Console.WriteLine(result.Trim());
            }

        }
    }
}
