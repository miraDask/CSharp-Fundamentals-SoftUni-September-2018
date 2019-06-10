namespace _02.SongEncryption
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string namePattern = @"^(?<artist>[A-Z][a-z]*\ ?([a-z]+[\'\ ]?)*)\:";

                string songPattern = @"\:([A-Z]+\ ?)+";

                Match nameMatches = Regex.Match(input, namePattern);
                Match songMatches = Regex.Match(input, songPattern);

                if (nameMatches.Success == false || songMatches.Success == false)
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }

                string artistName = nameMatches.Groups["artist"].ToString();
                string song =songMatches.Groups[0].ToString();
            }
        }

        //private static string GetSong(MatchCollection songMatches)
        //{
        //    string name = string.Empty;

        //    foreach (Match match in songMatches)
        //    {
        //        name += match.Groups["song"].ToString();
        //    }

        //    return name;
        //}

        //private static string GetName(MatchCollection nameMatches)
        //{
        //    string name = string.Empty;

        //    foreach (Match match in nameMatches)
        //    {
        //        name += match.ToString();
        //    }

        //    return name;
        //}
    }
}
