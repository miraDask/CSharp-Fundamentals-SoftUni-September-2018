

namespace _02.BakingRush
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string events = Console.ReadLine();

            int energy = 100;
            int coins = 100;

            List<string> eventsInfo = events.Split('|').ToList();

            for (int i = 0; i < eventsInfo.Count; i++)
            {
                string[] currentInfo = GetInfo(eventsInfo[i]);

                string word = currentInfo[0];
                int number = int.Parse(currentInfo[1]);

                if (word == "rest")
                {
                    int gainedEnergy = 0;

                    if (energy + number <= 100)
                    {
                        energy += number;
                        gainedEnergy = number;
                    }
                    else
                    {
                        energy += 100 - energy;
                        gainedEnergy = 100 - energy;
                    }

                    Console.WriteLine($"You gained {gainedEnergy} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (word == "order")
                {
                    if (energy >= 30)
                    {
                        coins += number;
                        energy -= 30;

                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else if(energy - 30 < 0)
                    {

                        Console.WriteLine($"You had to rest!");

                        energy += 50;
                    }
                }
                else
                {
                    string ingredient = word;
                    int price = number;

                    if (coins - price > 0)
                    {
                        coins -= price;
                        Console.WriteLine($"You bought {ingredient}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                        return;
                    }
                }
            }
            
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }

        private static string[] GetInfo(string info)
        {
            string[] currentInfo = info.Split('-').ToArray();

            return currentInfo;
        }
    }
}
