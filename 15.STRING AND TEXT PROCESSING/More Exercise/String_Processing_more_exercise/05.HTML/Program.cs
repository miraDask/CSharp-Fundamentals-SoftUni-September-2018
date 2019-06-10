using System;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = $"<h1>\n    {Console.ReadLine()}\n</h1>";
            Console.WriteLine(title);

            string coment = $"<article>\n    {Console.ReadLine()}\n</article>";
            Console.WriteLine(coment);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of comments")
                {
                    break;
                }

                string div = $"<div>\n    {input}\n</div>";
                Console.WriteLine(div);
            }
        }
    }
}
