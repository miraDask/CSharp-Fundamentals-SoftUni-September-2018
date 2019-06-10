namespace _03.Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
            this.Points = 0;
            this.Goals = 0;
        }
        public string Name { get; set; }

        public int Points { get; set; }

        public int Goals { get; set; }
    }

    class Program
    {

        static void Main()
        {
            List<Team> teams = new List<Team>();

            string key = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }


                string regex = string.Format(@"(.)*({0}(?<teamA>[a-zA-z]+){0})(.)*({0}(?<teamB>[a-zA-z]+){0})(.)*((?<teamAGoals>[\d]+)\:(?<teamBGoals>[\d]+))(.)*", Regex.Escape(new string(key)));

                Match match = Regex.Match(input, regex);

                if (!match.Success)
                {
                    continue;
                }
                
                string teamA = new string(match.Groups["teamA"].Value.Reverse().ToArray()).ToUpper();
                int goalsOfTeamA = int.Parse(match.Groups["teamAGoals"].Value.ToString());

                string teamB = new string(match.Groups["teamB"].Value.Reverse().ToArray()).ToUpper();
                int goalsOfTeamB = int.Parse(match.Groups["teamBGoals"].Value.ToString());


                if (!teams.Any(t => t.Name == teamA))
                {
                    Team currentTeam = new Team(teamA);
                    int points = GetPoints(goalsOfTeamA, goalsOfTeamB);
                    currentTeam.Points += points;
                    currentTeam.Goals += goalsOfTeamA;
                    teams.Add(currentTeam);
                }
                else
                {
                    Team currentTeam = teams.Find(t => t.Name == teamA);
                    int points = GetPoints(goalsOfTeamA, goalsOfTeamB);
                    currentTeam.Points += points;
                    currentTeam.Goals += goalsOfTeamA;
                }

                if (!teams.Any(t => t.Name == teamB))
                {
                    Team currentTeam = new Team(teamB);
                    int points = GetPoints(goalsOfTeamB, goalsOfTeamA);
                    currentTeam.Points += points;
                    currentTeam.Goals += goalsOfTeamB;
                    teams.Add(currentTeam);
                }
                else
                {
                    Team currentTeam = teams.Find(t => t.Name == teamB);
                    int points = GetPoints(goalsOfTeamB, goalsOfTeamA);
                    currentTeam.Points += points;
                    currentTeam.Goals += goalsOfTeamB;
                }

            }

            Console.WriteLine("League standings:");

            int count = 1;
            foreach (var team in teams.OrderByDescending(t => t.Points).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{count}. {team.Name} {team.Points}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            count = 1;
            foreach (var team in teams.OrderByDescending(t => t.Goals).ThenBy(x => x.Name))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");

                if (count == 3)
                {
                    return;
                }
                count++;
            }

        }

        private static int GetPoints(int firstTeam, int secondTeam)
        {
            if (firstTeam > secondTeam)
            {
                return 3;
            }
            else if (secondTeam > firstTeam)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
