namespace _03.AnonymousVox
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string encodedText = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new[] { '{', '}' },StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"([a-zA-Z]+)(.*)\1");

            MatchCollection matches = regex.Matches(encodedText);

            int placeholdersCount = 0;

            foreach (Match match in matches)
            {
                if (placeholdersCount >= values.Length)
                {
                    break;
                }

                
                string placeholder = match.Groups[2].ToString();
                encodedText = encodedText.Replace(placeholder,values[placeholdersCount]);
                placeholdersCount++;
            }

            Console.WriteLine(encodedText);
        }
    }
}
