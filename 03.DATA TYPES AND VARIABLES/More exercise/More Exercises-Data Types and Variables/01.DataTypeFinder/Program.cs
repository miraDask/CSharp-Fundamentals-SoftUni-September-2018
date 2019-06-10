using System;

namespace _01.DataTypeFinder
{
    public class Program
    {
        public static void Main()
        {
           
            while (true)
            {
                string input = Console.ReadLine();
                bool isInteger = int.TryParse(input, out int integer);
                bool isFloatingPointNum = double.TryParse(input, out double floatingPointNum);
                bool isChar = char.TryParse(input, out char character);
                bool isBoolean = bool.TryParse(input, out bool boolean);

                if (input == "END")
                {
                    break;
                }
                else if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloatingPointNum)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{input} is character type");

                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");

                }                
                else
                {
                    Console.WriteLine($"{input} is string type");

                }
            }
        }
    }
}
