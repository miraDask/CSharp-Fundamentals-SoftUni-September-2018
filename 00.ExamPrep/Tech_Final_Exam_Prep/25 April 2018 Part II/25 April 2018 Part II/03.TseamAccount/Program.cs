namespace _03.TseamAccount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> account = Console.ReadLine().Split(new[] {' '}).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Play!")
                {
                    break;
                }

                string[] commandData = input.Split();

                string command = commandData[0];
                string game = commandData[1];

                switch (command)
                {

                    case "Install":

                        if (!account.Contains(game))
                        {
                            account.Add(game);
                        }
                        break;

                    case "Uninstall":

                        if (account.Contains(game))
                        {
                            int indexOfGame = account.FindIndex(g => g == game);

                            if (account[indexOfGame + 1].Contains('-'))
                            {
                                account.Remove(account[indexOfGame + 1]);
                            }
                            account.Remove(game);
                        }
                        break;

                    case "Update":
                        if (account.Contains(game))
                        {
                            int indexOfGame = account.FindIndex(g => g == game);

                            string temp = account[indexOfGame];
                            account.Remove(account[indexOfGame]);
                            account.Add(temp);
                        }
                        break;

                    case "Expansion":

                        string[] expansionInfo = game.Split(new[] {'-'});
                        string gameToExpand = expansionInfo[0];

                        if (account.Contains(gameToExpand))
                        {
                            int indexOfGame = account.FindIndex(g => g == gameToExpand);

                            account.Insert(indexOfGame + 1,string.Join(":",expansionInfo) );
                           
                        }
                        break;
                   
                }
            }

            Console.WriteLine(string.Join(" ", account));
        }
    }
}
