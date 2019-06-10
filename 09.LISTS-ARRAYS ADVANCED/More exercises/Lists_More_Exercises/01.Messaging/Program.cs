

namespace _01.Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<char> letters = Console.ReadLine().ToList();
            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                string tempString = numbers[i];
                List<char> temp = tempString.ToList();

                int indexWanted = 0;

                for (int j = 0; j < temp.Count; j++)
                {
                    indexWanted += temp[j] - '0';
                }

                int realIndex = indexWanted % letters.Count;

                result += letters[realIndex];

                letters.RemoveAt(realIndex);

                
            }
            Console.WriteLine(result);
        }
    }
}
