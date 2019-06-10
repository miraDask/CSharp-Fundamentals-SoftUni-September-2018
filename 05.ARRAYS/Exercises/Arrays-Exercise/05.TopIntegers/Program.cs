

namespace _05.TopIntegers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int currentNum = i + 1; currentNum < numbers.Length; currentNum++)
                {
                    if (numbers[currentNum] != numbers[numbers.Length - 1] && numbers[i] <= numbers[currentNum] )
                    {
                        break;
                    }
                    else if (currentNum == numbers.Length - 1 && numbers[i] > numbers[currentNum])
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    
                }
            }
            Console.Write(numbers[numbers.Length - 1]);
            Console.WriteLine();
        } 
    }
}
