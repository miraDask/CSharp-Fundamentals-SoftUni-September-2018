
namespace _10._SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var userPoinsRegister = new Dictionary<string, int>();
            var languageRegister = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] examInfo = input.Split('-').ToArray();

                string name = examInfo[0];

                if (examInfo[1] == "banned")
                {

                    if (userPoinsRegister.ContainsKey(name))
                    {
                        userPoinsRegister.Remove(name);
                    }

                }
                else
                {
                    string codeLanguage = examInfo[1];
                    int points = int.Parse(examInfo[2]);

                    if (!userPoinsRegister.ContainsKey(name) || userPoinsRegister[name] < points)
                    {
                        userPoinsRegister[name] = points;
                    }

                    if (!languageRegister.ContainsKey(codeLanguage))
                    {
                        languageRegister[codeLanguage] = 1;
                    }
                    else
                    {
                        languageRegister[codeLanguage]++;
                    }

                }
            }

            var orderedUserReg = userPoinsRegister.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key);
            var orderedLanguageReg = languageRegister.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key);

            Console.WriteLine("Results:");

            foreach (var pair in orderedUserReg)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var pair in orderedLanguageReg)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
