namespace _04.IronGirder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Slide rule")
                {
                    break;
                }

                string[] townData = input.Split(':');
                string townName = townData[0];
                string[] data = townData[1].Split(new string[] { "->" },StringSplitOptions.None);
                int time = 0;
                int currentPassengers = int.Parse(data[1]);

                Town currentTown = new Town(townName);

                if (data[0] == "ambush")
                {
                    if (!towns.Any(n => n.Name == townName))
                    {
                        continue;
                    }
                    else
                    {
                        int townIndex = towns.FindIndex(t => t.Name == townName);
                        towns[townIndex].Passengers -= currentPassengers;
                        towns[townIndex].Time = 0;
                    }
                }
                else
                {
                    time = int.Parse(data[0]);

                    if (!towns.Any(t => t.Name == townName))
                    {

                        currentTown.Time = time;
                        currentTown.Passengers += currentPassengers;
                        towns.Add(currentTown);
 
                    }
                    else
                    {
                        int townIndex = towns.FindIndex(t => t.Name == townName);
                        towns[townIndex].Passengers += currentPassengers;
                        if (towns[townIndex].Time == 0 || towns[townIndex].Time > time)
                        {
                            towns[townIndex].Time = time;
                        }
                    }
                }
            }

            foreach (Town town in towns.OrderBy(t => t.Time).ThenBy(x => x.Name))
            {
                if (town.Time > 0 && town.Passengers > 0)
                {
                    Console.WriteLine($"{town.Name} -> Time: {town.Time} -> Passengers: {town.Passengers}");
                }
            }
        }
    }

    public class Town
    {
        public Town(string name)
        {
            this.Name = name;
            this.Passengers = 0;
            this.Time = 0;
        }
        public string Name { get; set; }

        public int Passengers { get; set; }

        public int Time { get; set; }
    }
}
