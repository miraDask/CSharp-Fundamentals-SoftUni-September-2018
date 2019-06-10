
namespace _05.MultiplicationSign
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int lastnum = int.Parse(Console.ReadLine());

            int[] sequenceOfInts = new int[3];
            sequenceOfInts[0] = firstnum;
            sequenceOfInts[1] = secondnum;
            sequenceOfInts[2] = lastnum;

            PrintResultFromMultiplication(sequenceOfInts);
        }

        private static void PrintResultFromMultiplication(int[] numbers)
        {
            string result = string.Empty;
            int negativCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativCount++;
                }
                else if (numbers[i] == 0)
                {
                    result = "zero";
                    break;
                }
                
            }

            if ( result == "zero")
            {
                Console.WriteLine(result);

            }
            else if (negativCount == 1 || negativCount == 3)
            {
                result = "negative";
                Console.WriteLine(result);
            }
            else
            {
                result = "positive";
                Console.WriteLine(result);
            }           
        }
    }
}
