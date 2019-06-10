namespace Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> allData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> users = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ");
                string contest = tokens[1];
                string user = tokens[0];
                int point = int.Parse(tokens[2]);

                if (allData.ContainsKey(contest) == false)
                {
                    allData.Add(contest, new Dictionary<string, int>());
                }

                if (allData[contest].ContainsKey(user) == false)
                {
                    allData[contest].Add(user, 0);
                }

                if (allData[contest][user] < point)
                {
                    allData[contest][user] = point;
                }
            }

            int counter = 1;
            foreach (var data in allData)
            {
                Console.WriteLine($"{data.Key}: {data.Value.Count} participants");

                foreach (var user in data.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"{counter++}. {user.Key} <::>  {user.Value}");
                }

                counter = 1;
            }

            foreach (var data in allData)
            {
                foreach (var user in data.Value)
                {
                    if (users.ContainsKey(user.Key) == false)
                    {
                        users.Add(user.Key, 0);
                    }

                    users[user.Key] += user.Value;
                }
            }

            Console.WriteLine("Individual standings:");
            foreach (var user in users.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{counter++}. {user.Key} -> {user.Value}");
            }
        }
    }
}