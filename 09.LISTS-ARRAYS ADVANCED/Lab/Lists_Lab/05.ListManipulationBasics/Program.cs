namespace _05.ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string info = Console.ReadLine();

                if (info == "end")
                {
                    break;
                }

                string[] dataArray = info.Split();

                string command = dataArray[0];

                switch (command)
                {
                    case "Add":
                        int number = int.Parse(dataArray[1]);
                        numbers.Add(number);
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(dataArray[1]);
                        numbers.Remove(numberToRemove);
                        break;

                    case "RemoveAt":
                        int index = int.Parse(dataArray[1]);
                        numbers.RemoveAt(index);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(dataArray[1]);
                        int indexToInsert = int.Parse(dataArray[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
