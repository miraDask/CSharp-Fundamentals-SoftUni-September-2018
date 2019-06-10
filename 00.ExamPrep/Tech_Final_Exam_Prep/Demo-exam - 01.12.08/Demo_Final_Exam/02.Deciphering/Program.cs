using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] replacementInfo = Console.ReadLine().Split();

            Regex validationRegex = new Regex(@"^[d-z\#\|\{\}]*$");
            Match match = validationRegex.Match(text);

            if (!match.Success)
            {
                Console.WriteLine("This is not the book you are looking for.");

            }
            else
            {
               
                StringBuilder decodedText = new StringBuilder();

                foreach (var charachter in text)
                {

                    decodedText.Append((char)(charachter - 3));

                }

                string partToReplace = replacementInfo[0];
                string newPart = replacementInfo[1];

               string result = decodedText.Replace(partToReplace,newPart).ToString();

                Console.WriteLine(result);
            }

        }

    }
}
