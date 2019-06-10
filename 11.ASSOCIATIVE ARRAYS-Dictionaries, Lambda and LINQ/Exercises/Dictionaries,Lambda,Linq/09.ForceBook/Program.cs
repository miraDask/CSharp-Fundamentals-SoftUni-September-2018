

namespace _09.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var forceBook = new Dictionary<string, List<string>>();



            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] firstTypeInfo = input.Split(" | ");

                    string forceSide = firstTypeInfo[0];
                    string forceUser = firstTypeInfo[1];

                    if (!forceBook.ContainsKey(forceSide))
                    {

                        forceBook.Add(forceSide, new List<string>());
                       

                    }

                    if (!forceBook.Any(kvp => kvp.Value.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }



                }
                else
                {
                    string[] secondTypeInfo = input.Split(" -> ").ToArray();

                    string forceUser = secondTypeInfo[0];
                    string forceSide = secondTypeInfo[1];

                    bool IsExisting = false;
                    string currentForce = string.Empty;

                    foreach (var pair in forceBook)
                    {

                        if (pair.Value.Contains(forceUser))
                        {
                            currentForce = pair.Key;
                            IsExisting = true;
                            break;
                        }

                    }


                    if (IsExisting)
                    {
                        forceBook[currentForce].Remove(forceUser);
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());


                    }

                    if (!forceBook[forceSide].Contains(forceUser))
                    {
                        forceBook[forceSide].Add(forceUser);


                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            var result = forceBook.OrderByDescending(pair => pair.Value.Count).ThenBy(pair => pair.Key);


            foreach (var pair in result)
            {
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");

                    foreach (var value in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {value}");
                    }
                }
            }
        }
    }
}
