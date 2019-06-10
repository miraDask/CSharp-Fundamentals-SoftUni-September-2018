using System;

namespace _02a.FromLeftToTheRight
{
    public class Program
    {
        public static void Main()
        {

            int limit = int.Parse(Console.ReadLine());
         



            for (int i = 0; i < limit; i++)
            {
                string input = Console.ReadLine();

                string[] leftRight = input.Split(' ');

                string leftString = leftRight[0];

                string rightString = leftRight[1];

                long rightSum = 0;
                long leftSum = 0;



                for (int index = 0; index < leftString.Length; index++)
                {
                    if (leftString[index] != '-')
                    {
                        leftSum += (long)Char.GetNumericValue(leftString[index]);
                    }

                }
                for (int index = 0; index < rightString.Length; index++)
                {
                    if (rightString[index] != '-')
                    {
                        rightSum += (long)Char.GetNumericValue(rightString[index]);
                    }

                }

                long leftNum = long.Parse(leftString);
                long rightNum = long.Parse(rightString);

               
                if (leftNum > rightNum)
                {
                    Console.WriteLine(leftSum);
                }
                else
                {
                    Console.WriteLine(rightSum);
                }

            }
        }
    }
}
