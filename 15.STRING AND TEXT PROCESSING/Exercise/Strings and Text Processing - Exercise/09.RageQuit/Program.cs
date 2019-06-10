namespace _09.RageQuit
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<char> usedChars = new List<char>();
            List<string> resultString = new List<string>();

            string currentString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                int number = 0;

                if (char.IsNumber(currentChar))
                {
                    if (i < input.Length - 1 && char.IsNumber(input[i + 1]))
                    {
                        string temt = $"{currentChar}{input[i + 1]}";

                        number = int.Parse(temt);

                        i++;
                    }
                    else if (i == input.Length - 1 || !char.IsNumber(input[i + 1]))
                    {
                        number = int.Parse(currentChar.ToString());
                    }

                    if (number > 0)
                    {
                        for (int j = 1; j <= number; j++)
                        {

                            resultString.Add(currentString.ToUpper());
                        }

                        for (int k = 0; k < currentString.Length; k++)
                        {
                            if (char.IsLetter(currentString[k]) && !usedChars.Contains(char.ToUpper(currentString[k])))
                            {

                                usedChars.Add(char.ToUpper(currentString[k]));
                                continue;

                            }

                            if (!char.IsLetter(currentString[k]) && !usedChars.Contains(currentString[k]))
                            {
                                usedChars.Add(currentString[k]);
                            }
                        }

                    }

                    currentString = string.Empty;

                }
                else
                {
                    currentString += currentChar;

                }
            }
            // Console.WriteLine(string.Join(string.Empty,usedChars));
            Console.WriteLine($"Unique symbols used: {usedChars.Count}");
            Console.WriteLine(string.Join(string.Empty, resultString));
        }
    }
}
