using System;

namespace _07.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter < 'a' + n; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + n; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + n; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
