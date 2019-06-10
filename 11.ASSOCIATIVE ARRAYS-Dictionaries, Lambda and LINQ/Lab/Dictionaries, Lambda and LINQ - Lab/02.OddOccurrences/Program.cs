
namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] sequence = Console.ReadLine().ToLower().Split().ToArray();

            var oddOccurrencesReg = new Dictionary<string, int>();

            for (int i = 0; i < sequence.Length; i++)
            {
                if (!oddOccurrencesReg.ContainsKey(sequence[i]))
                {
                    oddOccurrencesReg.Add(sequence[i], 1);
                }
                else
                {
                    oddOccurrencesReg[sequence[i]]++;
                }
            }

            var result = oddOccurrencesReg.Where(pair => pair.Value % 2 == 1);

            foreach (var pair in result)
            {
                Console.Write($"{pair.Key} ");
            }

            Console.WriteLine();
        }
        
    }
}
