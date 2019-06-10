

namespace _04.TribonacciSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

           
            if (limit == 1)
            {
                Console.WriteLine("1");
            }
            else if (limit == 2)
            {
                Console.WriteLine("1 1");

            }
            else if (limit == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                PrintTribonacciSequence(limit);

            }
        }

        public static void PrintTribonacciSequence(int num)
        {
            string result = "1 1 2";
            int fib1 = 1;
            int fib2 = 1;
            int fib3 = 2;
            int temp = 0;

            for (int i = 4; i <= num; i++)
                {
                    temp = fib3 + fib2 + fib1;
                    fib1 = fib2;
                    fib2 = fib3;
                    fib3 = temp;

                    result += " " + fib3;
                }

            Console.WriteLine(result);
        }
    }
}
