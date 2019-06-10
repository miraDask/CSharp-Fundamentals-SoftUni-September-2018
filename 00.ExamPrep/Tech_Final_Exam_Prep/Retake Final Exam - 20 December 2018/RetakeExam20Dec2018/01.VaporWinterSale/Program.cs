namespace _01.VaporWinterSale
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string[]> gamesRegister = new Dictionary<string, string[]>();
            // will fold gameName , downloadableContent(gameRegister[gameName][0]), price(gameRegister[gameName][1])

            string[] input = Console.ReadLine().Split(", ");

            foreach (var game in input)
            {

                if (game.Contains(':'))
                {
                    string[] gameInfo = game.Split(':');
                    string gameName = gameInfo[0];
                    string downloadableContent = gameInfo[1];

                    if (gamesRegister.ContainsKey(gameName) == true)
                    {
                        gamesRegister[gameName][0] = downloadableContent;
                        double gamePrice = double.Parse(gamesRegister[gameName][1]);
                        gamePrice *= 1.20;
                        gamesRegister[gameName][1] = gamePrice.ToString();

                    }

                }
                else
                {
                    string[] gameInfo = game.Split('-');
                    string gameName = gameInfo[0];
                    string price = gameInfo[1];

                    if (gamesRegister.ContainsKey(gameName) == false)
                    {
                        gamesRegister.Add(gameName, new string[2]);
                    }

                    gamesRegister[gameName][1] = price;
                }
            }

            foreach (var game in gamesRegister)
            {
                if (game.Value[0] == null)
                {
                    double price = double.Parse(game.Value[1]);
                    price *= 0.8;
                    game.Value[1] = $"{price:f2}";
                }
                else
                {
                    double price = double.Parse(game.Value[1]);
                    price *= 0.5;
                    game.Value[1] = $"{price:f2}";
                }
            }

            foreach (var game in gamesRegister.Where(g => g.Value[0] != null).OrderBy(g => double.Parse(g.Value[1])))
            {
                Console.WriteLine($"{game.Key} - {game.Value[0]} - {game.Value[1]}");
            }

            foreach (var game in gamesRegister.Where(g => g.Value[0] == null).OrderByDescending(g => double.Parse(g.Value[1])))
            {
                Console.WriteLine($"{game.Key} - {game.Value[1]}");
            }
        }
    }
}
