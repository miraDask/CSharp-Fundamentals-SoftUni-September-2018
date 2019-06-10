

namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] originalArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] condensedArr = new int[originalArr.Length - 1];

            while (originalArr.Length > 1)
            {

                for (int i = 0; i < originalArr.Length-1; i++)
                {
                    
                    condensedArr[i] = originalArr[i] + originalArr[i + 1];
                }

                originalArr = condensedArr;
                condensedArr = new int[originalArr.Length - 1];

            }
            Console.WriteLine(originalArr[0]);
        }
    }
}
