using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^|(?<=\s))([a-z0-9]+)([\-\._]?)([a-z0-9]+)@[a-z]+\-?[a-z]+\.[a-z]+([\.a-z]+)?(\b|(?=\s))");

            MatchCollection matchedEmails = regex.Matches(input);

            foreach (Match email in matchedEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
