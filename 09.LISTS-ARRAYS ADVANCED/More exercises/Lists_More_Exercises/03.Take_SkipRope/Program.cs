

namespace _03.Take_SkipRope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> charackters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    numbers.Add(input[i] - '0');
                }
                else
                {
                    charackters.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);

                }
            }

            var resultMessage = new List<char>();

            var tempList = new List<char>();

            for (int i = 0; i < skipList.Count; i++)
            {
                int skipRange = skipList[i];
                int takeRange = takeList[i];


                tempList = charackters.Take(takeRange).ToList();
                resultMessage.AddRange(tempList);

                if (i == skipList.Count - 1)
                {
                    break;
                }

                if (takeRange > 0)
                {
                  charackters.RemoveRange(0,takeRange);
                     
                }
                                
                tempList = charackters.Skip(skipRange).ToList();
                
                charackters = tempList;
            
            }

            var result = new StringBuilder();

            foreach (var c in resultMessage)
            {
                result.Append(c);
            }
            Console.WriteLine(result);

        }
    }
}
