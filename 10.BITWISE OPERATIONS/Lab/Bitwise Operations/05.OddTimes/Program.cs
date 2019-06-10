using System;
using System.Linq;

namespace _05.OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result = result ^ input[i];
            }

            Console.WriteLine(result);
        }
    }
}
