namespace _03.StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string codeToEncrypt = Console.ReadLine();

                Regex keyRegex = new Regex(@"[starSTAR]");

                MatchCollection allKeyLetters = keyRegex.Matches(codeToEncrypt);

                int key = allKeyLetters.Count;

                string encryptedMessage = string.Empty;

                foreach (var character in codeToEncrypt)
                {
                    encryptedMessage += (char)(character - key);
                }

                Regex checker = new Regex(@"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!([AD])![^@\-!:>]*->[0-9]+");

                Match match = checker.Match(encryptedMessage);

                if (match.Success)
                {
                    char attackType = char.Parse(match.Groups[2].ToString());
                    string planet = match.Groups[1].ToString();

                    if (attackType == 'A')
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
