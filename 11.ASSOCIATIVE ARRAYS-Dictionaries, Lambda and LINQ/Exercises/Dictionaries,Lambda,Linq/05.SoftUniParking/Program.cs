

namespace _05.SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            var registrationData = new Dictionary<string, string>();

            for (int i = 0; i < limit; i++)
            {
                string[] usersData = Console.ReadLine().Split(' ').ToArray();

                string command = usersData[0];
                string userName = usersData[1];

                if (command == "register")
                {
                    
                    string licensePlateNumber = usersData[2];

                    if (!registrationData.ContainsKey(userName))
                    {
                        registrationData.Add(userName, licensePlateNumber);

                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                }
                else
                {
                    if (!registrationData.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");

                        registrationData.Remove(userName);
                    }
                }
            }

            foreach (var kvp in registrationData)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
