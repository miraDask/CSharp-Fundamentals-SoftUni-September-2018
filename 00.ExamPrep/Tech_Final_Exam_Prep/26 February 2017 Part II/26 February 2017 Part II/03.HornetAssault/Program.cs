using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            List<long> hornets = Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long totalHornetPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long numOfBeesInCurrentBeehive = beehives[i];

                if (numOfBeesInCurrentBeehive < totalHornetPower)
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else if (numOfBeesInCurrentBeehive == totalHornetPower)
                {
                    beehives.RemoveAt(i);
                    totalHornetPower -= hornets[0];
                    hornets.RemoveAt(0);
                    i--;

                }
                else
                {
                    beehives.RemoveAt(i);
                    beehives.Insert(i, (numOfBeesInCurrentBeehive - totalHornetPower));
                    totalHornetPower -= hornets[0];
                    hornets = hornets.Skip(1).ToList();
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
