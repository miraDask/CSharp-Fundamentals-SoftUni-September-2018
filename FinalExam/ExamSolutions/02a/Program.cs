using System;

namespace _02a
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] splitedInput = input.Split(':');

                string artist = splitedInput[0];
                string song = splitedInput[1];

                bool artistIsValid = ValidateInput(artist);
                bool songIsValid = ValidateSong(song);

                if (artistIsValid == false || songIsValid == false)
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }

                int key = artist.Length;

                string encryptedInput = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ' && input[i] != '\'' && input[i] != ':')
                    {
                        int code = (int)input[i] + key;
                        if (char.IsLower(input[i]))
                        {
                            if (code > 122)
                            {
                                code = 96 + (code - 122);
                            }
                            encryptedInput += (char)code;
                        }
                        else
                        {
                            if (code > 90)
                            {
                                code = 64 + (code - 90);

                            }
                            encryptedInput += (char)code;
                        }
                    }
                    else
                    {
                        if (input[i] == ':')
                        {
                            encryptedInput += '@';
                        }
                        else
                        {
                            encryptedInput += input[i];
                        }

                    }


                }

                Console.WriteLine($"Successful encryption: {encryptedInput}");
            }



        }

        private static bool ValidateSong(string song)
        {
            for (int i = 0; i < song.Length; i++)
            {
                if (song[i] != ' ')
                {
                    if (char.IsLower(song[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool ValidateInput(string artist)
        {
            for (int i = 0; i < artist.Length; i++)
            {
                if (i == 0)
                {
                    if (char.IsLower(artist[i]))
                    {
                        return false;
                    }
                }
                else
                {

                    if (char.IsUpper(artist[i]))
                    {
                        return false;
                    }

                    if (!char.IsLetter(artist[i]) && artist[i] != ' ' && artist[i] != '\'')
                    {
                        return false;

                    }

                }
            }
            return true;
        }
    }
}
