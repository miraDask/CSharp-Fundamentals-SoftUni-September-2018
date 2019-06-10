namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
 
          string input = Console.ReadLine();

            Regex regex = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b") ;

            MatchCollection matchedNames = regex.Matches(input);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();

            // other solution:

            //string regex = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";

            //string input = Console.ReadLine();

            //MatchCollection matchedNames = Regex.Matches(input, regex);

            //foreach (Match name in matchedNames)
            //{
            //    Console.Write(name.Value + " ");
            //}
            //Console.WriteLine();
        }
    }
}
