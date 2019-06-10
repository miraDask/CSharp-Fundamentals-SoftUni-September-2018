namespace _10.WinningTicket
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            string[] input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < input.Length; i++)
            {
                string currentTicket = input[i];

                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftPart = currentTicket.Substring(0, 10);
                string rightPart = currentTicket.Substring(10);

                int length = 0;
                char symbol = ' ';

                for (int j = 10; j >= 6; j--)
                {
                    if (leftPart.Contains(new string('@', j)) && rightPart.Contains(new string('@', j)))
                    {
                        length = j;
                        symbol = '@';
                        break;
                    }
                    else if (leftPart.Contains(new string('#', j)) && rightPart.Contains(new string('#', j)))
                    {
                        length = j;
                        symbol = '#';
                        break;
                    }
                    else if (leftPart.Contains(new string('^', j)) && rightPart.Contains(new string('^', j)))
                    {
                        length = j;
                        symbol = '^';
                        break;
                    }
                    else if (leftPart.Contains(new string('$', j)) && rightPart.Contains(new string('$', j)))
                    {
                        length = j;
                        symbol = '$';
                        break;
                    }
                }

                if (length < 6)
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                }
                else if (length == 10)
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - {length}{symbol} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - {length}{symbol}");
                }

            }
        }
    }
}
