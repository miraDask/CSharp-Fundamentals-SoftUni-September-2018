namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, decimal[]> demons = new Dictionary<string, decimal[]>();

            string[] input = Console.ReadLine()
                .Split(new[] { ',', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[^0-9+\-*\/\.]";

            string damagePattern = @"[+-]*[0-9]+[.]?[0-9]*";

            string multiplicationAndDivision = @"[\/*]";


            for (int i = 0; i < input.Length; i++)
            {
                string currentDemon = input[i];

                demons.Add(currentDemon, new decimal[2]);

                MatchCollection healthMatches = Regex.Matches(currentDemon, healthPattern);

                int totalHealth = 0;

                foreach (Match match in healthMatches)
                {
                    totalHealth += char.Parse(match.Value);
                }

                demons[currentDemon][0] = totalHealth;

                MatchCollection damageMatches = Regex.Matches(currentDemon, damagePattern);

                decimal damage = 0;

                foreach (Match match in damageMatches)
                {
                    damage += decimal.Parse(match.Value.ToString());
                }

                MatchCollection matches = Regex.Matches(currentDemon, multiplicationAndDivision);


                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        if (match.Value == "*")
                        {
                            damage *= 2;
                        }
                        else
                        {
                            damage /= 2;
                        }
                    }

                }

                demons[currentDemon][1] = damage;

            }

            foreach (var demon in demons.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage ");
            }

        }
    }
}
