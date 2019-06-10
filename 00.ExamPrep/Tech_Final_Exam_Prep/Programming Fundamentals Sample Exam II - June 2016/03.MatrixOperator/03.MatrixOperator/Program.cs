using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> rows = new List<List<int>>();

            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRows; i++)
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

                rows.Add(input);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] manipulationData = input.Split();

                string command = manipulationData[0];

                switch (command)
                {
                    case "remove":
                        string type = manipulationData[1];
                        string position = manipulationData[2];
                        int element = int.Parse(manipulationData[3]);

                        if (type == "positive")
                        {
                            if (position == "row")
                            {
                                List<int> newRow = rows[element].Where(x => x <= 0).ToList();
                                rows.RemoveAt(element);
                                rows.Insert(element, newRow);
                            }
                            else
                              {
                                for (int i = 0; i < rows.Count; i++)
                                {
                                    if (rows[i].Count > element && rows[i][element] > 0)
                                    {
                                        rows[i].RemoveAt(element);
                                    }
                                }
                            }
                        }
                        else if (type == "negative")
                        {
                            if (position == "row")
                            {
                                List<int> newRow = rows[element].Where(x => x >= 0).ToList();
                                rows.RemoveAt(element);
                                rows.Insert(element, newRow);
                            }
                            else
                            {
                                for (int i = 0; i < rows.Count; i++)
                                {
                                    if (rows[i].Count > element && rows[i][element] < 0)
                                    {
                                        rows[i].RemoveAt(element);
                                    }

                                }
                            }
                        }
                        else if (type == "odd")
                        {
                            if (position == "row")
                            {

                                for (int i = 0; i < rows[element].Count; i++)
                                {
                                    int currentNumber = rows[element][i];

                                    if (currentNumber < 0)
                                    {
                                        currentNumber *= -1;
                                    }

                                    if (currentNumber % 2 != 0)
                                    {
                                        rows[element].Remove(currentNumber);
                                    }
                                }
                         
                            }
                            else
                            {
                                for (int i = 0; i < rows.Count; i++)
                                {
                                    if (rows[i].Count > element && rows[i][element] % 2 != 0)
                                    {
                                        rows[i].RemoveAt(element);
                                    }

                                }
                            }
                        }
                        else
                        {
                            if (position == "row")
                            {
                                for (int i = 0; i < rows[element].Count; i++)
                                {
                                    int currentNumber = rows[element][i];

                                    if (currentNumber < 0)
                                    {
                                        currentNumber *= -1;
                                    }

                                    if (currentNumber % 2 == 0)
                                    {
                                        rows[element].Remove(i);
                                        i--;
                                    }
                                }
                            }
                            else
                            {
                                for (int i = 0; i < rows.Count; i++)
                                {
                                    if (rows[i].Count > element && rows[i][element] % 2 == 0)
                                    {
                                        rows[i].RemoveAt(element);
                                    }

                                }
                            }
                        }

                        break;

                    case "swap":
                        int firstRow = int.Parse(manipulationData[1]) - 1;
                        int secondRow = int.Parse(manipulationData[2]) - 1;
                        List<int> temp = rows[firstRow];
                        rows[firstRow] = rows[secondRow];
                        rows[secondRow] = temp;
                        break;

                    case "insert":
                        int currentRow = int.Parse(manipulationData[1]);
                        int newElement = int.Parse(manipulationData[2]);
                        rows[currentRow - 1].Insert(0, newElement);
                        break;
                }
            }

            foreach (var list in rows)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
