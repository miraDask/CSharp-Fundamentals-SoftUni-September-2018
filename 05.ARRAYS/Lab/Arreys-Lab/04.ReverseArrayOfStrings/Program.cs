

namespace _04.ReverseArrayOfStrings
{
    using System;   

    public class Program
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length / 2; i++)
            {
                string tempValue = text[i];

                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = tempValue;

               
            }
            Console.WriteLine(string.Join(" ",text));
            

        }
    }
}
