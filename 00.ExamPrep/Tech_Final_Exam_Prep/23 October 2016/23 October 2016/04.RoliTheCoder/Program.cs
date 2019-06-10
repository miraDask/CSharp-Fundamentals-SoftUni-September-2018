namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Dictionary<int, string> idAndEventNameReg = new Dictionary<int, string>();
            Dictionary<string, List<string>> eventNamesAndParticipants = new Dictionary<string, List<string>>();


            string idPattern = @"^[\d]+";
            string namePattern = @"(?<=\#)[\S]+";
            string participantsPattern = @"(?<=\@)[\S]+";


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                int id = 0;
                Match idMatch = Regex.Match(input, idPattern);

                if (!idMatch.Success)
                {
                    continue;
                }

                id = int.Parse(idMatch.Value);

                Match nameMatch = Regex.Match(input, namePattern);

                if (!nameMatch.Success)
                {
                    continue;
                }

                string eventName = nameMatch.ToString();

                if (!idAndEventNameReg.ContainsKey(id))
                {
                    idAndEventNameReg[id] = eventName;

                    eventNamesAndParticipants[eventName] = new List<string>();
                }

                if (idAndEventNameReg[id] != eventName)
                {
                    continue;
                }
                else
                {
                    MatchCollection participantsMatches = Regex.Matches(input, participantsPattern);


                    if (participantsMatches.Count > 0)
                    {
                        foreach (Match match in participantsMatches)
                        {
                            string participant = match.Value;

                            if (!eventNamesAndParticipants[eventName].Contains(participant))
                            {
                                eventNamesAndParticipants[eventName].Add(participant);
                            }

                        }
                    }
                }


            }

            foreach (var pair in eventNamesAndParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value.Count}");

                foreach (var participant in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}
