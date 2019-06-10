using System;
using System.Linq;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string codedMessage = Console.ReadLine();
                string decryptedMassege = string.Empty;

                if (codedMessage == "find")
                {
                    break;
                }

                int j = 0;

                for (int i = 0; i < codedMessage.Length; i++)
                {

                    decryptedMassege += (char)(codedMessage[i] - numbers[j]);

                    if (j == numbers.Length - 1)
                    {
                        j = 0;

                    }
                    else
                    {
                        j++;
                    }

                }

                int indexBeforeTypeOfTreasure = decryptedMassege.IndexOf('&');
                int indexAfterTypeOfTreasure = decryptedMassege.LastIndexOf('&');

                string typeOfTreasure = decryptedMassege.Substring(indexBeforeTypeOfTreasure + 1, indexAfterTypeOfTreasure - indexBeforeTypeOfTreasure - 1);

                int indexBeforeLocation = decryptedMassege.IndexOf('<');
                int indexAfterLocation = decryptedMassege.IndexOf('>');

                string location = decryptedMassege.Substring(indexBeforeLocation + 1 , indexAfterLocation - indexBeforeLocation - 1);

                Console.WriteLine($"Found {typeOfTreasure} at {location}");
            }

        }
    }
}
