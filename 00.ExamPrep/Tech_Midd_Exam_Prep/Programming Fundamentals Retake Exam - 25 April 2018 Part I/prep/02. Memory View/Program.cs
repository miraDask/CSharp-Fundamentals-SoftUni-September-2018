

namespace _02._Memory_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            string result = string.Empty;

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Visual Studio crash")
                {
                    break;
                }

                result += " " + input;

            }

            List<int> token = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x > 0).ToList();


            while (token.Count != 0)
            {
                int length = 0;

                token.RemoveRange(0, 3);

                length = token[0];

                token.RemoveAt(0);

                string codedWord = "";

                for (int i = 0; i < length; i++)
                {
                    codedWord += (char)token[0];
                    token.Remove(token[0]);
                }


                Console.WriteLine(codedWord);
            }


        }
    }
}

