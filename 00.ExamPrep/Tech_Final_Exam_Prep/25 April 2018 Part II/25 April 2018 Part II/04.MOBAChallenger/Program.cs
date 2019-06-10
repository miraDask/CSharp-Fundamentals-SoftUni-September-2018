namespace _04.MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        public Player(string name)
        {
            Name = name;
            PositionsAndSkillsReg = new Dictionary<string, int>();
            TotalSkillsPoints = 0;
        }
        public string Name { get; set; }

        public Dictionary<string, int> PositionsAndSkillsReg { get; set; }

        public int TotalSkillsPoints { get; set; }

    }
    public class Program
    {
        public static void Main()
        {
            List<Player> players = new List<Player>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains(" vs "))
                {
                    string[] data = input.Split(new string[] { " ", "vs" }, StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = data[0];
                    string secondPlayer = data[1];

                    if (players.Any(p => p.Name == firstPlayer) && players.Any(p => p.Name == secondPlayer))
                    {
                        Player playerOne = players.Find(p => p.Name == firstPlayer);
                        Player playerTwo = players.Find(p => p.Name == secondPlayer);

                        if (HasPositionMatch(playerTwo, playerOne))
                        {


                            if (playerOne.TotalSkillsPoints > playerTwo.TotalSkillsPoints)
                            {
                                players.Remove(playerTwo);
                            }
                            else if (playerTwo.TotalSkillsPoints > playerOne.TotalSkillsPoints)
                            {
                                players.Remove(playerOne);
                            }

                        }
                    }
                }
                else
                {
                    string[] data = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string playerName = data[0];
                    string position = data[1];
                    int skillPoints = int.Parse(data[2]);

                    if (!players.Any(p => p.Name == playerName))
                    {
                        Player newPlayer = new Player(playerName);
                        newPlayer.PositionsAndSkillsReg.Add(position, skillPoints);
                        newPlayer.TotalSkillsPoints += skillPoints;
                        players.Add(newPlayer);

                    }
                    else
                    {
                        Player player = players.Find(p => p.Name == playerName);

                        if (!player.PositionsAndSkillsReg.ContainsKey(position))
                        {
                            player.PositionsAndSkillsReg.Add(position, skillPoints);
                            player.TotalSkillsPoints += skillPoints;
                        }
                        else if (player.PositionsAndSkillsReg[position] < skillPoints)
                        {
                            player.PositionsAndSkillsReg[position] = skillPoints;
                            player.TotalSkillsPoints += player.PositionsAndSkillsReg[position] - skillPoints;
                        }

                    }


                }
            }

            foreach (var player in players.OrderByDescending(p => p.TotalSkillsPoints).ThenBy(pl => pl.Name))
            {
                Console.WriteLine($"{player.Name}: {player.TotalSkillsPoints} skill");

                foreach (var pair in player.PositionsAndSkillsReg.OrderByDescending(s => s.Value).ThenBy(sk => sk.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }

        }


        private static bool HasPositionMatch(Player playerTwo, Player playerOne)
        {
            foreach (var pair in playerOne.PositionsAndSkillsReg)
            {
                foreach (var kvp in playerTwo.PositionsAndSkillsReg)
                {
                    if (pair.Key == kvp.Key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
