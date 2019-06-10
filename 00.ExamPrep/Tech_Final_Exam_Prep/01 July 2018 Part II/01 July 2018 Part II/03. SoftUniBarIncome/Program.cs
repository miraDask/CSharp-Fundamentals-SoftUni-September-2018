namespace _03.SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            double totalIncome = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }
                
                Regex regex = new Regex(@"^%([A-Z][a-z]+)%[^\|\$\.\%]*?\<([a-zA-Z_0-9]+)\>[^\|\$\.\%]*?\|[^\|\$\.\%]*?(\d+)\|[^\|\$\.\%]*?(\d+\.\d+|\d+)\$$");

                Match match = regex.Match(input);
                

                if (match.Success)
                {
                    string name = match.Groups[1].Value.ToString();
                    string product = match.Groups[2].Value.ToString();
                    int quantity = int.Parse(match.Groups[3].Value.ToString());
                    double price = double.Parse(match.Groups[4].Value.ToString());
                    double income = quantity * price;
                    totalIncome += income;

                    Console.WriteLine($"{name}: {product} - {income:f2}");
                }

            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }

    }
}
