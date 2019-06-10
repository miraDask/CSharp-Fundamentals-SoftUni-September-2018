namespace _11.MathOperations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double result = Calculate(firstNum,@operator,secondNum);

            Console.WriteLine($"{result}");
        }

        private static double Calculate(double firstNum, char @operator, double secondNum)
        {
            double result = 0d;

            switch (@operator)
            {
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
            }

            return result;
        }
    }
}
