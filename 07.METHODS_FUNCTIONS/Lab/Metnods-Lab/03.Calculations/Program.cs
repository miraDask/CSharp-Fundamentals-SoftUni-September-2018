namespace _03.Calculations
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string calculation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (calculation)
            {
                case "add":
                    Add(firstNumber,secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Substract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
               


            }
        }

        private static void Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;

            Console.WriteLine(result);
        }

        private static void Substract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;

            Console.WriteLine(result);
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;

            Console.WriteLine(result);
        }

        private static void Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            Console.WriteLine(result);
        }
    }
}
