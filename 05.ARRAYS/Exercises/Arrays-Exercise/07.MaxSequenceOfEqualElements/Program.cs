

namespace _07.MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                string temp = numbers[i] + " ";

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        temp += numbers[j] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (temp.Length > result.Length)
                {
                    result = temp;
                }
            }
            Console.WriteLine(result);
        }
    }
}
