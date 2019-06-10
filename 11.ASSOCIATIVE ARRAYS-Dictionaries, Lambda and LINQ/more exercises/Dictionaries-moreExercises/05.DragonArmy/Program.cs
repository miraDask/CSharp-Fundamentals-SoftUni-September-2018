namespace _05.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dragon
    {
        public Dragon(string name)
        {
            Name = name;
            Damage = 45;
            Health = 250;
            Armor = 10;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> typeOfDragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonData = Console.ReadLine().Split().ToArray();
                string type = dragonData[0];
                string name = dragonData[1];

                Dragon currentDragon = new Dragon(name);
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (dragonData[2] != "null")
                {
                    damage = int.Parse(dragonData[2]);
                }
                else
                {
                    damage = currentDragon.Damage;
                }

                currentDragon.Damage = damage;

                if (dragonData[3] != "null")
                {
                    health = int.Parse(dragonData[3]);
                }
                else
                {
                    health = currentDragon.Health;
                }

                currentDragon.Health = health;

                if (dragonData[4] != "null")
                {
                    armor = int.Parse(dragonData[4]);
                }
                else
                {
                    armor = currentDragon.Armor;
                }

                currentDragon.Armor = armor;

                if (!typeOfDragons.ContainsKey(type))
                {
                    typeOfDragons[type] = new List<Dragon>();
                    typeOfDragons[type].Add(currentDragon);
                }
                else
                {
                    if (!typeOfDragons[type].Any(x => x.Name == name))
                    {
                        typeOfDragons[type].Add(currentDragon);
                    }
                    else
                    {
                        int index = typeOfDragons[type].FindIndex(x => x.Name == name);

                        typeOfDragons[type][index].Damage = damage;
                        typeOfDragons[type][index].Health = health;
                        typeOfDragons[type][index].Armor = armor;

                    }
                }


            }

            Dictionary<string, string> typesAverageStatus = new Dictionary<string, string>();

            string tempAverageStatus = string.Empty;

            foreach (var type in typeOfDragons)
            {
                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                foreach (var dragon in type.Value)
                {
                    averageDamage += dragon.Damage;
                    averageHealth += dragon.Health;
                    averageArmor += dragon.Armor;
                }

                averageDamage /= type.Value.Count;
                averageHealth /= type.Value.Count;
                averageArmor /= type.Value.Count;

                tempAverageStatus = $"::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})";
                typesAverageStatus[type.Key] = tempAverageStatus;
            }

            foreach (var type in typesAverageStatus)
            {
                Console.WriteLine($"{type.Key}{type.Value}");
                foreach (var pair in typeOfDragons)
                {
                    if (pair.Key == type.Key)
                    {
                        foreach (var dragon in pair.Value.OrderBy(x => x.Name))
                        {
                            Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                        }
                    }

                }
            }
        }
    }
}
