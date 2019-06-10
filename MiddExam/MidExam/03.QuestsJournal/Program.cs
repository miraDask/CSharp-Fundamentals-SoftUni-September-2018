using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokens = Console.ReadLine();
            List<string> questsJournal = tokens.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Retire!")
                {
                    break;
                }


                List<string> info = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = info[0];


                if (command == "Start")
                {
                    string quest = info[1];

                    if (!questsJournal.Contains(quest))
                    {
                        questsJournal.Add(quest);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Complete")
                {
                    string quest = info[1];

                    if (questsJournal.Contains(quest))
                    {
                        questsJournal.Remove(quest);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Side Quest")
                {
                    List<string> splitedSecondPart = info[1].Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();

                    string quest = splitedSecondPart[0];
                    string sideQuest = splitedSecondPart[1];

                    if (questsJournal.Contains(quest))
                    {
                        int indexOfQuest = questsJournal.IndexOf(quest);

                        if (!questsJournal.Contains(sideQuest))
                        {
                            if (indexOfQuest == questsJournal.Count - 1)
                            {
                                questsJournal.Add(sideQuest);
                            }
                            else
                            {
                                if (questsJournal[indexOfQuest + 1] == sideQuest)
                                {
                                    continue;
                                }
                                questsJournal.Insert(indexOfQuest + 1, sideQuest);
                            }
                        }

                    }
                }
                else if (command == "Renew")
                {
                    string quest = info[1];

                    if (questsJournal.Contains(quest))
                    {
                        int indexOfQuest = questsJournal.IndexOf(quest);

                        questsJournal.RemoveAt(indexOfQuest);
                        questsJournal.Add(quest);

                    }
                }

            }

            Console.WriteLine(string.Join(", ", questsJournal));
        }
    }
}
