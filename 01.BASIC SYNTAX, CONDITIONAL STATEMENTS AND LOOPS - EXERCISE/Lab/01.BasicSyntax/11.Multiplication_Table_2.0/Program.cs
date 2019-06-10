using System;

namespace _11.Multiplication_Table_2._0
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());

            if (startNum > 10)
            {
                Console.WriteLine($"{number} X {startNum} = {number * startNum}");
            }
            else
            {
                for (int i = startNum; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}
