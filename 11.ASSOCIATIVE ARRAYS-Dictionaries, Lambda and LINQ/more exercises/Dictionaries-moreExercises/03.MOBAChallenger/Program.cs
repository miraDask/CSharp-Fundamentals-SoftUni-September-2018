namespace _03.MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            
            Dictionary<string, Dictionary<string, int>> playersRegister = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playersTotalSkills = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains("vs"))
                {
                    string[] playerData = input.Split(" vs ").ToArray();

                    string firstPlayer = playerData[0];
                    string secondPlayer = playerData[1];

                    if (playersRegister.ContainsKey(firstPlayer) && playersRegister.ContainsKey(secondPlayer))
                    {
                        bool ContainsSamePositions = ContainsSamePosition(playersRegister[firstPlayer], playersRegister[secondPlayer]);

                        if (ContainsSamePositions)
                        {
                            int firstPlayerTotalSkills = GetTotalSkills(playersRegister[firstPlayer]);
                            int secondPlayerTotalSkills = GetTotalSkills(playersRegister[secondPlayer]);

                            if (firstPlayerTotalSkills == secondPlayerTotalSkills)
                            {
                                continue;
                            }
                            else
                            {
                                string loser = GetLoser(firstPlayer, firstPlayerTotalSkills, secondPlayer, secondPlayerTotalSkills);

                                playersRegister.Remove(loser);
                            }

                        }
                    }
                }
                else
                {
                    string[] playerData = input.Split(" -> ").ToArray();

                    string player = playerData[0];
                    string position = playerData[1];
                    int skill = int.Parse(playerData[2]);

                    Dictionary<string, int> playerPositionAndSkill = new Dictionary<string, int>();
                    playerPositionAndSkill[position] = skill;

                    if (!playersRegister.ContainsKey(player))
                    {
                        playersRegister[player] = playerPositionAndSkill;
                    }
                    else
                    {
                        if (!playersRegister[player].ContainsKey(position))
                        {
                            playersRegister[player][position] = skill;
                        }
                        else if (playersRegister[player][position] < skill)
                        {
                            playersRegister[player][position] = skill;
                        }
                    }

                }
            }

            foreach (var pair in playersRegister)
            {
                int totalSkills = GetTotalSkills(pair.Value);
                playersTotalSkills[pair.Key] = totalSkills;

            }

            foreach (var pair in playersTotalSkills.OrderByDescending(p => p.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} skill");
                foreach (var player in playersRegister)
                {
                    foreach (var elements in player.Value.OrderByDescending(x => x.Value).ThenBy(p => p.Key))
                    {
                        if (pair.Key == player.Key)
                        {
                            Console.WriteLine($"- {elements.Key} <::> {elements.Value}");
                        }
                    }
                }
            }
        }

        private static string GetLoser(string firstPlayer, int firstPlayerTotalSkills, string secondPlayer, int secondPlayerTotalSkills)
        {

            string loser = string.Empty;

            if (firstPlayerTotalSkills > secondPlayerTotalSkills)
            {
                loser = secondPlayer;
            }
            else
            {
                loser = firstPlayer;
            }

            return loser;
        }

        private static int GetTotalSkills(Dictionary<string, int> dictionary)
        {
            int totalSkills = 0;

            foreach (var pair in dictionary)
            {
                totalSkills += pair.Value;
            }

            return totalSkills;
        }

        private static bool ContainsSamePosition(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2)
        {
            foreach (var pair in dictionary1)
            {
                foreach (var kvp in dictionary2)
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
