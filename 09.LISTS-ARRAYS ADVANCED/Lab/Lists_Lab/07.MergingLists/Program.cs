namespace _07.MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            List<int> shorterList = FindShorterList(firstList,secondList);
            List<int> longerList = FindLongerList(firstList,secondList);

            for (int i = 0; i < longerList.Count; i++)
            {
                if (i < shorterList.Count)
                {
                    resultList.Add(firstList[i]);
                    resultList.Add(secondList[i]);
                }
                else
                {
                    resultList.Add(longerList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));

        }

        private static List<int> FindLongerList(List<int> firstList, List<int> secondList)
        {
            if (firstList.Count >= secondList.Count)
            {
                return firstList;
            }
            else
            {
                return secondList;
            }
        }

        private static List<int> FindShorterList(List<int> firstList, List<int> secondList)
        {
            if (firstList.Count <= secondList.Count)
            {
                return firstList;
            }
            else
            {
                return secondList;
            }
        }
    }
}
