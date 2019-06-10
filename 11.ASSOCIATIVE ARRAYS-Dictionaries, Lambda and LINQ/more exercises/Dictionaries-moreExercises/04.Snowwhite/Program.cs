namespace _04.Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dwarfsRegister = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                string[] dwarfsData = input.Split(" <:> ").ToArray();

                string name = dwarfsData[0];
                string hatColor = dwarfsData[1];
                int physics = int.Parse(dwarfsData[2]);

                if (!dwarfsRegister.ContainsKey(hatColor))
                {
                    dwarfsRegister[hatColor] = new Dictionary<string, int>();
                    dwarfsRegister[hatColor][name] = physics;
                }
                else if(dwarfsRegister.ContainsKey(hatColor) && !dwarfsRegister[hatColor].ContainsKey(name))
                {
                    dwarfsRegister[hatColor][name] = physics;
                }
                else if(dwarfsRegister[hatColor].ContainsKey(name) && dwarfsRegister[hatColor][name] < physics)
                {
                    dwarfsRegister[hatColor][name] = physics;
                }
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();

            foreach (var hatColor in dwarfsRegister.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
