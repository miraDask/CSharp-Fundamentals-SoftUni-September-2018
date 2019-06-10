

namespace _05.AddSubtract
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            int result = Substraction(SumOf2Integers(firstNum, secondNum), lastNum);
            Console.WriteLine(result);

        }

        public static int SumOf2Integers(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        public static int Substraction(int sum, int number)
        {

            int result = sum - number;
                return result;
        }
    }
}
