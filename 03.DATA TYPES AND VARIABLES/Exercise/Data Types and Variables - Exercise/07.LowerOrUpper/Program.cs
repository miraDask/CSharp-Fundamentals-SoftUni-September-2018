using System;

namespace _07.LowerOrUpper
{
    public class Program
    {
        public static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if ((int)letter >= 97 && (int)letter <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
