

namespace _04.ArrayRotation
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int limit = int.Parse(Console.ReadLine());

            for (int count = 0; count < limit; count++)
            {
                int tempNum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                     
                    if (i == 0)
                    {
                        tempNum = numbers[i] ;
                        
                    }
                    else
                    {
                        numbers[i - 1] = numbers[i];
                    }
                }
                numbers[numbers.Length - 1] = tempNum;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}

