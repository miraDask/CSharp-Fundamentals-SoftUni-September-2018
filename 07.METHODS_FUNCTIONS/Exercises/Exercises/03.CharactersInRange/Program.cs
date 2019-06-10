

namespace _03.CharactersInRange
{
    using System;

    public class Program
    {
        public static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintCharSequence(start, end);
            Console.WriteLine();
        }

        public static void PrintCharSequence(char start, char end)
        {

            if ((int) end < (int)start)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            for (int i = (int)start + 1; i < (int)end; i++)
            {
                Console.Write((char)i + " ");
            }
        }

       
    }
}
