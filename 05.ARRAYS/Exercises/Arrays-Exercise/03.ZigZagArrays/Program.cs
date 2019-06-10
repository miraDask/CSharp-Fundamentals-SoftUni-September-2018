

namespace _03.ZigZagArrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            int[] firstArr = new int[limit];
            int[] secondArr = new int[limit];

            for (int row = 1; row <= limit; row++)
            {
                int[] currentArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                
                    if (row % 2 != 0)
                    {
                        firstArr[row - 1] = currentArr[0];
                        secondArr[row - 1] = currentArr[1];
                    }
                    else
                    {
                        firstArr[row - 1] = currentArr[1];
                        secondArr[row - 1] = currentArr[0];
                    }
                

            }

            Console.WriteLine(string.Join(" ",firstArr));
            Console.WriteLine(string.Join(" ",secondArr));

        }
    }
}
