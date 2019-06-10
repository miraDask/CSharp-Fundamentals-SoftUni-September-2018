using System;

namespace _02.FromLeftToTheRight
{
    public class Program
    {
        public static void Main()
        {

            int limit = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < limit; i++)
            {
                string input = Console.ReadLine();
                string leftString = "";
                string rightString = "";

                int rightSum = 0;
                int leftSum = 0;



                for (int index = 0; index < input.Length; index++)
                {
                    
                    if (input[index] != ' ')
                    {
                        rightString += input[index];

                        if (input[index] != '-')
                        {
                            rightSum += (int)Char.GetNumericValue(input[index]);
                        }

                    }
                    else if (input[index] == ' ')
                    {
                        leftSum = rightSum;
                        rightSum = 0;
                        leftString = rightString;
                        rightString = "";
                        continue;
                    }
                }

                int leftNum = int.Parse(leftString);
                int rightNum = int.Parse(rightString);

                
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
