namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Legion
    {
        public Legion(string name)
        {
            Name = name;
            Soldiers = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public int Activity { get; set; }

        // will hold soldierType(key)-soldierCount(value)
       public Dictionary<string, long> Soldiers { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Legion> legions = new List<Legion>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(token[0]);
                string legionName = token[1];
                string soldierType = token[2];
                long soldierCount = long.Parse(token[3]);

                if (!legions.Any(x => x.Name == legionName))
                {
                    legions.Add(new Legion(legionName));
                }

                Legion currentLegion = legions.Find(x => x.Name == legionName);

                if (!currentLegion.Soldiers.ContainsKey(soldierType))
                {
                    currentLegion.Soldiers.Add(soldierType, 0); 
                }

                currentLegion.Soldiers[soldierType] += soldierCount;

                if (currentLegion.Activity < lastActivity)
                {
                    currentLegion.Activity = lastActivity;
                }


            }

            string[] input = Console.ReadLine().Split('\\');

            if (input.Length == 1)
            {
                string soldierType = input[0];

                foreach (Legion legion in legions.OrderByDescending(x => x.Activity))
                {
                    if (legion.Soldiers.ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Activity} : {legion.Name}");
                    }
                }
            }
            else
            {
                
                int activity = int.Parse(input[0]);
                string soldierType = input[1];

                foreach (Legion legion in legions
                    .Where(x => x.Soldiers.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Soldiers[soldierType]))
                {
                    if (legion.Activity < activity)
                    {
                        Console.WriteLine($"{legion.Name} -> {legion.Soldiers[soldierType]}");
                    }
                }
            }
        }
    }
}
