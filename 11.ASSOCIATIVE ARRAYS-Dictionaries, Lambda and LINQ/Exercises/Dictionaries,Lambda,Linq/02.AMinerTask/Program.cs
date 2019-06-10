using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            Dictionary<string, int> info = new Dictionary<string, int>();
            
            string tempResource = "";

            while (true)
            {
                string input = Console.ReadLine();

                int tempSum = 0;

                if (input == "stop")
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    if (!info.ContainsKey(input))
                    {
                        info.Add(input, tempSum);

                    }

                    tempResource = input;
                }
                else
                {
                    int resourceQuantity = int.Parse(input);

                    tempSum = info[tempResource] + resourceQuantity;


                    info[tempResource] = tempSum;

                }

                count++;

            }

            foreach (var kvp in info)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
