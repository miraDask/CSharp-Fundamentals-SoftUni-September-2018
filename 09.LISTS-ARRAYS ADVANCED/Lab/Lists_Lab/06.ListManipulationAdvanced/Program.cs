namespace _06.ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;

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
                        isChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(dataArray[1]);
                        numbers.Remove(numberToRemove);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        int index = int.Parse(dataArray[1]);
                        numbers.RemoveAt(index);
                        isChanged = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(dataArray[1]);
                        int indexToInsert = int.Parse(dataArray[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        isChanged = true;
                        break;

                    case "Contains":
                        int numberToCheck = int.Parse(dataArray[1]);

                        if (numbers.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                        break;

                    case "GetSum":
                        Console.WriteLine( numbers.Sum());
                        break;

                    case "Filter":

                        string condition = dataArray[1];
                        int numberToSearch = int.Parse(dataArray[2]);

                        if (condition == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < numberToSearch)));
                        }
                        else if (condition == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= numberToSearch)));
                        }
                        else if (condition == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > numberToSearch)));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= numberToSearch)));
                        }

                        break;
                }
            }

            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
