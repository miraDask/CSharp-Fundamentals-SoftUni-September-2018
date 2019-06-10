namespace _01.Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Band
    {
        public Band(string name)
        {
            this.Name = name;
            this.Members = new List<string>();
            this.TotalTime = 0;
        }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public long TotalTime { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Band> bands = new List<Band>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                string[] splitedInput = input.Split(';');

                string command = splitedInput[0];

                if (command == "Add")
                {
                    string bandName = splitedInput[1].TrimStart();
                    string[] members = splitedInput[2].Split(',');

                    if (bands.Any(b => b.Name == bandName) == false)
                    {
                        Band newBand = new Band(bandName);
                        bands.Add(newBand);
                    }

                    Band currentBand = bands.Find(b => b.Name == bandName);

                    foreach (var member in members)
                    {
                        string currentMember = member.TrimStart();
                        if (currentBand.Members.Contains(currentMember) == false)
                        {
                            currentBand.Members.Add(currentMember);
                        }

                    }

                }
                else
                {
                    string bandName = splitedInput[1].TrimStart();
                    int time = int.Parse(splitedInput[2].TrimStart());

                    if (bands.Any(b => b.Name == bandName) == false)
                    {
                        Band newBand = new Band(bandName);
                        bands.Add(newBand);
                    }

                    Band currentBand = bands.Find(b => b.Name == bandName);
                    currentBand.TotalTime += time;

                }
            }

            long totalTimeOfAllBands = GetTime(bands);

            Console.WriteLine($"Total time: {totalTimeOfAllBands}");

            foreach (var band in bands.OrderByDescending(b => b.TotalTime).ThenBy(b => b.Name))
            {
                Console.WriteLine($"{band.Name} -> {band.TotalTime}");
            }

            string finalInput = Console.ReadLine();
            Band wantedBand = bands.Find(b => b.Name == finalInput);

            Console.WriteLine($"{wantedBand.Name}");

            foreach (var member in wantedBand.Members)
            {
                Console.WriteLine($"=> {member}");
            }


        }

        private static long GetTime(List<Band> bands)
        {
            long time = 0;

            foreach (var band in bands)
            {
                time += band.TotalTime;

            }

            return time;
        }
    }
}
