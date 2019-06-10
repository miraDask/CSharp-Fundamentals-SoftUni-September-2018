

namespace _02.GrainsOfSands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Mort")
                {
                    break;
                }

                string[] comand = input.Split();
                string comandWord = comand[0];
                int value = 0;
                int replacement = 0;


                switch (comandWord)
                {
                    case "Add":
                    case "Remove":
                    case "Increase":
                    case "Collapse":
                        value = int.Parse(comand[1]);
                        break;
                    case "Replace":
                        value = int.Parse(comand[1]);
                        replacement = int.Parse(comand[2]);
                        break;

                }

                if (comandWord == "Add")
                {
                    sequence.Add(value);
                }
                else if (comandWord == "Remove")
                {
                    if (sequence.Contains(value))
                    {
                        sequence.Remove(value);
                    }
                    else if(value >= 0 && value < sequence.Count - 1)
                    {
                        sequence.RemoveAt(value);
                    }
                    else
                    {
                        continue;
                    }
                   
                }
                else if (comandWord == "Replace")
                {

                    if (sequence.Contains(value))
                    {
                        int index = sequence.IndexOf(value);

                        sequence[index] = replacement;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else if (comandWord == "Increase")
                {
                    bool isFound = false;
                    int foundNum = 0;

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] >= value)
                        {
                            isFound = true;
                            foundNum = sequence[i];
                            break;
                        }

                    }

                    if (isFound)
                    {
                        var tempSeq = sequence.Select(x => x + foundNum);
                        sequence = tempSeq.ToList();
                        
                    }
                    else
                    {
                        var tempSeq = sequence.Select(x => x + sequence[sequence.Count - 1]);
                        sequence = tempSeq.ToList();
                    
                    }
                }
                else if (comandWord == "Collapse")
                {
                    var tempSeq = sequence.Where(x => x >= value);
                    sequence = tempSeq.ToList();
                  
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
