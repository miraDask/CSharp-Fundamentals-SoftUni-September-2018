namespace _08._Letters_Change_Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string text = input[i];
                char firstLetter = text[0];
                text = text.Remove(0, 1);
                char lastLetter = text[text.Length - 1];
                text = text.Remove(text.Length - 1, 1);

                decimal number = decimal.Parse(text);

                int positionOfFirstLetter = char.ToLower(firstLetter) - 96;
                int positionOfLastLetter = char.ToLower(lastLetter) - 96;


                if (char.IsLower(firstLetter))
                {
                    number *= positionOfFirstLetter;

                }
                else
                {
                    number /= positionOfFirstLetter;
                }

                if (char.IsLower(lastLetter))
                {
                    number += positionOfLastLetter;
                }
                else
                {
                    number -= positionOfLastLetter;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
