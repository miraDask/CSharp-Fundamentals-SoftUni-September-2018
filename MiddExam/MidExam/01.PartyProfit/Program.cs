using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            int initialHealth = 100;
            int coins = 0;
            int currentHealth = initialHealth;
            int roomsCount = 0;

            for (int i = 0; i < rooms.Count; i++)
            {
                roomsCount++;
                string[] info = rooms[i].Split(' ').ToArray();

                string itemOrMonster = info[0];
                int power = int.Parse(info[1]);

                if (itemOrMonster == "potion")
                {
                    if (currentHealth > 0)
                    {
                        if (currentHealth + power <= initialHealth)
                        {
                            currentHealth += power;

                            Console.WriteLine($"You healed for {power} hp.");
                            Console.WriteLine($"Current health: {currentHealth} hp.");
                        }
                        else
                        {

                            Console.WriteLine($"You healed for {initialHealth - currentHealth} hp.");

                            currentHealth += initialHealth - currentHealth;

                            Console.WriteLine($"Current health: {currentHealth} hp.");
                        }
                    }
                }
                else if (itemOrMonster == "chest")
                {
                    coins += power;
                    Console.WriteLine($"You found {power} coins.");
                }
                else
                {

                    currentHealth -= power;

                    if (currentHealth > 0)
                    {
                        Console.WriteLine($"You slayed {itemOrMonster}.");

                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {itemOrMonster}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        return;
                    }
                }
            }


            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {currentHealth}");
        }
    }
}
