
namespace _01.Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var contestsRegister = new Dictionary<string, string>();
            var userRegister = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                if (input == "end of contests")
                {
                    break;
                }

                string[] tokens = input.Split(':').ToArray();
                string contest = tokens[0];
                string password = tokens[1];

                contestsRegister[contest] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (true)
            {
                if (input == "end of submissions")
                {
                    break;
                }

                string[] tokens = input.Split("=>").ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestsRegister.ContainsKey(contest))
                {
                    if (contestsRegister[contest] == password)
                    {
                        
                        if (!userRegister.ContainsKey(username))
                        {
                            userRegister.Add(username, new Dictionary<string, int>());
                            userRegister[username].Add(contest,points);
                            
                        }
                        else if (userRegister.ContainsKey(username) && !userRegister[username].ContainsKey(contest))
                        {
                            userRegister[username].Add(contest, points);
                        }
                        
                        if(userRegister[username][contest] < points)
                        {
                            userRegister[username][contest] = points;
                        }
                        
                    }
                }

                input = Console.ReadLine();

            }

            string bestUser = string.Empty;
            int totalPoints = 0;


            foreach (var username in userRegister)
            {
                int currentTotalPoints = 0;

                foreach (var contest in username.Value)
                {
                    currentTotalPoints += contest.Value;
                    
                }

            string currentBestUser = username.Key;

                if (currentTotalPoints > totalPoints)
                {
                    totalPoints = currentTotalPoints;
                    bestUser = currentBestUser;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {totalPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var username in userRegister.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{username.Key}");

                foreach (var pair in username.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
