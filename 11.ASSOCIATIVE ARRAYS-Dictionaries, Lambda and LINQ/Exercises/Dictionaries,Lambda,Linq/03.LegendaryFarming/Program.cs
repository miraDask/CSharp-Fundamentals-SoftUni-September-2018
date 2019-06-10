

namespace _03.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var pressiousMaterials = new Dictionary<string, int>
            {
                { "fragments", 0 },
                { "shards", 0},
                { "motes", 0}
            };

            var junkMaterials = new Dictionary<string, int>();
            int price = 250;
            string obtaintMaterial = string.Empty;
            bool isBought = false;

            while (true)
            {
                if (isBought)
                {
                    break;
                }
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ')
                    .ToArray();

                int tempQuantity = 0;
                int sum = 0;

                for (int i = 0; i < input.Length; i++)
                {

                    if (i % 2 == 0)
                    {
                        tempQuantity = int.Parse(input[i]);

                    }
                    else
                    {
                        string material = input[i];

                        if (materialIsPressious(material))
                        {

                            pressiousMaterials[material] += tempQuantity;

                            if (pressiousMaterials[material] >= price)
                            {
                                obtaintMaterial = material;
                                pressiousMaterials[material] -= price;
                                isBought = true;
                                break;
                            }

                        }
                        else
                        {
                            if (!junkMaterials.ContainsKey(material))
                            {
                                junkMaterials.Add(material, tempQuantity);
                            }
                            else
                            {
                                sum = junkMaterials[material];
                                sum += tempQuantity;
                                junkMaterials[material] = sum;
                            }
                        }
                    }
                }


            }

            string legendaryItem = string.Empty;

            if (obtaintMaterial == "fragments")
            {
                legendaryItem = "Valanyr";
            }
            else if (obtaintMaterial == "shards")
            {
                legendaryItem = "Shadowmourne";
            }
            else
            {
                legendaryItem = "Dragonwrath";
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            var result = pressiousMaterials
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key) ;

          
            foreach (var material in result)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            result = junkMaterials.OrderBy(pair => pair.Key);

            foreach (var material in result)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static bool materialIsPressious(string material)
        {
            bool result = false;
            if (material == "shards" || material == "fragments" || material == "motes")
            {
                result = true;
            }

            return result;
        }
    }
}
