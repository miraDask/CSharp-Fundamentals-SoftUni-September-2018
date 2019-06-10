using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            MatchCollection matchedNums = regex.Matches(input);

            string[] numbers = matchedNums.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
