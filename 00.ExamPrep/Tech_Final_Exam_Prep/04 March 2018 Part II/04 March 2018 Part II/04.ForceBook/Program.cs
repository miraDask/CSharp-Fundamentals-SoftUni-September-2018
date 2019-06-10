namespace _04.ForceBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> forceSideReg = new Dictionary<string, List<string>>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains('|'))
                {
                    string[] data = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    string forceSide = data[0];
                    string forceUser = data[1];

                    if (!forceSideReg.ContainsKey(forceSide))
                    {
                        forceSideReg.Add(forceSide, new List<string>());

                    }
                    if (!forceSideReg.Any(x => x.Value.Contains(forceUser)))
                    {
                        forceSideReg[forceSide].Add(forceUser);
                    }

                }
                else
                {
                    string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = data[0];
                    string forceSide = data[1];

                    bool exists = false;
                    string side = string.Empty;

                    foreach (var pair in forceSideReg)
                    {
                        if (pair.Value.Contains(forceUser))
                        {
                            exists = true;
                            side = pair.Key;
                            break;
                        }
                    }

                    if (exists)
                    {
                        forceSideReg[side].Remove(forceUser);
                    }

                    if (!forceSideReg.ContainsKey(forceSide))
                    {
                        forceSideReg.Add(forceSide, new List<string>());

                    }

                    if (!forceSideReg[forceSide].Contains(forceUser))
                    {
                        forceSideReg[forceSide].Add(forceUser);
                    }


                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

            }

            foreach (var kvp in forceSideReg.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                if (kvp.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    foreach (var user in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
