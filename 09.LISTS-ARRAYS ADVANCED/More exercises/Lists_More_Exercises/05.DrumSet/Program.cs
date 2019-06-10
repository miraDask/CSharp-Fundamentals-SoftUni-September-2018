
namespace _05.DrumSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> currentCondition = GetList(drumSet);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(input);

                for (int i = 0; i < currentCondition.Count; i++)
                {
                    int damage = currentCondition[i] - hitPower;
                    int currentInitialPower = drumSet[i];


                    if (currentCondition[i] == 0)
                    {
                        continue;
                    }

                    if (damage <= 0 )
                    {
                        double currentPrice = drumSet[i] * 3;

                        if (budget >= currentPrice)
                        {
                            currentCondition[i] = currentInitialPower;
                            budget -= currentPrice;
                        }
                        else
                        {
                            currentCondition[i] = 0;
                          
                        }
                    }
                    else
                    {
                        currentCondition[i] = damage;
                    }
                }
            }

            var resultLine = currentCondition.Where(x => x > 0);

            Console.WriteLine(string.Join(' ',resultLine));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }

        private static List<int> GetList(List<int> drumSet)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < drumSet.Count; i++)
            {
                result.Add(drumSet[i]);
            }

            return result;
        }
    }
}
