namespace _02.ActivationKeys
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            List<string> validKeys = new List<string>();

            string[] input = Console.ReadLine().Split('&');

            foreach (var key in input)
            {
                string pattern = @"^[A-Za-z0-9]{25}$|^[A-Za-z0-9]{16}$";

                Match match = Regex.Match(key, pattern);

                if (match.Success == true)
                {
                    string validKey = string.Empty;

                    for (int i = 0; i < key.Length; i++)
                    {


                        if (char.IsDigit(key[i]))
                        {
                            int number = int.Parse(key[i].ToString());
                            number = 9 - number;
                            validKey += number.ToString();
                        }
                        else if (char.IsLower(key[i]))
                        {
                            validKey += key[i].ToString().ToUpper();
                        }
                        else
                        {
                            validKey += key[i];
                        }


                    }

                    AddValidKey(validKey, validKeys);
                }
            }

            Console.WriteLine(string.Join(", ", validKeys));
        }

        private static void AddValidKey(string validKey, List<string> validKeys)
        {
            string key = string.Empty;

            if (validKey.Length == 16)
            {
                for (int i = 0; i < validKey.Length; i++)
                {
                    string partOfString = validKey.Substring(i, 4);
                    key += partOfString + "-";
                    i += 3;

                }
            }
            else
            {
                for (int i = 0; i < validKey.Length; i++)
                {

                    string partOfString = validKey.Substring(i, 5);
                    key += partOfString + "-";
                    i += 4;

                }
            }

            validKeys.Add(key.TrimEnd('-'));
        }
    }
}
