
namespace _01.CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq ;

    public class Program
    {
        public static void Main()
        {
            int[] numberSeq = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numberReg = new Dictionary<int, int>();

            for (int i = 0; i < numberSeq.Length; i++)
            {
                if (!numberReg.ContainsKey(numberSeq[i]))
                {
                    numberReg[numberSeq[i]] = 1;
                }
                else
                {
                    numberReg[numberSeq[i]]++;
                }
            }

            foreach (var pair in numberReg.OrderBy(pair => pair.Key))
            {

                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
