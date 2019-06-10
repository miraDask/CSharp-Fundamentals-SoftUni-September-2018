
namespace _02._Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(0,words.Length);

                string temp = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
