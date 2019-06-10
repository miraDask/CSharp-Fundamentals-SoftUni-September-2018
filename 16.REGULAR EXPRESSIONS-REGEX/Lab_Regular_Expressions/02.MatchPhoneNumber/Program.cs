using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            MatchCollection matchedNumbers = regex.Matches(input);

            string[] numbers = matchedNumbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
