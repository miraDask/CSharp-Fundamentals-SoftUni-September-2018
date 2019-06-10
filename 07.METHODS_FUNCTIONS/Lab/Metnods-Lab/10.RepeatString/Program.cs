namespace _10.RepeatString
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());

            StringBuilder text = GetText(word, timesToRepeat);

            Console.WriteLine(text);
        }

        private static StringBuilder GetText(string word, int timesToRepeat)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < timesToRepeat; i++)
            {
                text.Append(word);
            }

            return text;
        }
    }
}
