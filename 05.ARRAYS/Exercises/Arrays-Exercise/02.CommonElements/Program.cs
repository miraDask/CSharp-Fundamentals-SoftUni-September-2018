

namespace _02.CommonElements
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j] == secondArr[i])
                    {
                        Console.Write(firstArr[j] + " ");
                    }
                }
            }
            Console.WriteLine();

            
            
        }
    }
}
