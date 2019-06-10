
namespace _05.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            int userCount = int.Parse(Console.ReadLine());

            var teamList = new List<Team>();

            if (userCount <= 0)
            {
                return;
            }
            for (int i = 0; i < userCount; i++)
            {

                string[] input = Console.ReadLine().Split('-').ToArray();

                string creator = input[0];
                string name = input[1];



                bool teamExists = teamList.Any(item => item.Name == name);
                bool creatorExists = teamList.Any(item => item.Creator == creator);

                if (!teamExists && !creatorExists)
                {
                    Team currentTeam = new Team(name, creator);

                    teamList.Add(currentTeam);

                    Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
                }
                else if (teamExists)
                {
                    Console.WriteLine($"Team {name} was already created!");

                }
                else if (creatorExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");

                }
            }


            while (true)
            {
                string additianalInput = Console.ReadLine();

                if (additianalInput == "end of assignment")
                {
                    break;
                }
                string[] additionalData = additianalInput.Split("->").ToArray();

                string nameOfMember = additionalData[0];
                string teamName = additionalData[1];

                bool teamExists = teamList.Any(t => t.Name == teamName);
                bool memberExists = teamList.Any(t => t.Members.Contains(nameOfMember));
                bool IsCreator = teamList.Any(t => t.Creator == nameOfMember);

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                else if (memberExists || IsCreator)
                {
                    Console.WriteLine($"Member {nameOfMember} cannot join team {teamName}!");
                    continue;
                }
                else if (teamExists && !memberExists && !IsCreator)
                {
                    int teamIndex = teamList.FindIndex(x => x.Name == teamName);
                    teamList[teamIndex].Members.Add(nameOfMember);
                }


            }

            var sortedTeamList = teamList.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name);
            var disbandedList = new List<Team>();

            foreach (Team team in sortedTeamList)
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.Creator}");

                    foreach (var member in team.Members.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }

                if (team.Members.Count == 0)
                {
                    disbandedList.Add(team);

                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var team in disbandedList.OrderBy(team => team.Name))
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}
