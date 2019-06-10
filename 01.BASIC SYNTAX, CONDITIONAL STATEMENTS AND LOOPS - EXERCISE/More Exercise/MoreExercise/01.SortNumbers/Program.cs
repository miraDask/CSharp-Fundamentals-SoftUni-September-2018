using System;

namespace _01.SortNumbers
{
    public class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int biggest = 0;
            int midd = 0;
            int smallest = 0;

            if ( firstNum > secondNum && firstNum > thirdNum)
            {
                biggest = firstNum;

                if (secondNum > thirdNum )
                {
                    midd = secondNum;
                    smallest = thirdNum;
                }
                else
                {
                    midd = thirdNum;
                    smallest = secondNum;
                }
            }
            else if( secondNum > firstNum && secondNum > thirdNum)
            {
                biggest = secondNum;
                if (firstNum > thirdNum)
                {
                    midd = firstNum;
                    smallest = thirdNum;
                }
                else
                {
                    midd = thirdNum;
                    smallest = firstNum;
                }
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                biggest = thirdNum;

                if (firstNum > secondNum)
                {
                    midd = firstNum;
                    smallest = secondNum;
                }
                else
                {
                    midd = secondNum;
                    smallest = firstNum;
                }
            }


            Console.WriteLine(biggest);
            Console.WriteLine(midd);
            Console.WriteLine(smallest);
        }
    }
}
