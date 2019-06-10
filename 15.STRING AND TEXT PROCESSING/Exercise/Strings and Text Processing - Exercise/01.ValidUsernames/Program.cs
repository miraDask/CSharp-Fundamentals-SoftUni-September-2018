namespace _01.ValidUsernames
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentUsername = input[i];
                string tempString = string.Empty;

                if (currentUsername.Length > 3 && currentUsername.Length < 16)
                {
                    for (int j = 0; j < currentUsername.Length; j++)
                    {

                        char currentChar = currentUsername[j];

                        if (char.IsLetter(currentChar) || char.IsNumber(currentChar) || currentChar == '_' || currentChar == '-')
                        {
                            tempString += currentChar;
                        }
                    }

                }

                if (tempString == currentUsername)
                {
                    validUsernames.Add(currentUsername);
                }
            }

            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
