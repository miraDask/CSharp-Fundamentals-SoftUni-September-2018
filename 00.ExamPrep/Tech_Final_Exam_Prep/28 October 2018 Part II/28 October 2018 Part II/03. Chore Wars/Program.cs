namespace _03._Chore_Wars
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            int timeForDishes = 0;
            int timeForCleaning = 0;
            int timeForLaundry = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wife is happy")
                {
                    break;
                }
                
                Regex dishesCommand = new Regex(@"<([a-z0-9]*)>");

                Regex cleaningCommand = new Regex(@"\[([A-Z0-9]*)\]");

                Regex laundryCommand = new Regex(@"\{[\S]*\}");

                string matchedDishesCommand = dishesCommand.Match(input).ToString();
                string matchedCleaningCommand = cleaningCommand.Match(input).ToString();
                string matchedLaundryCommand = laundryCommand.Match(input).ToString();

                timeForDishes += GetTime(matchedDishesCommand);
                timeForCleaning += GetTime(matchedCleaningCommand);
                timeForLaundry += GetTime(matchedLaundryCommand);
            }

            int totalTime = timeForDishes + timeForCleaning + timeForLaundry;

            string result = $"Doing the dishes - {timeForDishes} min.{Environment.NewLine}" +
                $"Cleaning the house - {timeForCleaning} min.{Environment.NewLine}" +
                $"Doing the laundry - {timeForLaundry} min.{Environment.NewLine}" +
                $"Total - {totalTime} min.";

            Console.WriteLine(result);
        }

        private static int GetTime(string command)
        {
            int time = 0;

            for (int i = 0; i < command.Length; i++)
            {
                try
                {
                    time += int.Parse(command[i].ToString());
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return time;
        }
    }
}
