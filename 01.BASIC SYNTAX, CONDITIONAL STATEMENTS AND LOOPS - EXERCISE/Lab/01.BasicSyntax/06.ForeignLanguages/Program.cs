using System;

namespace _06.ForeignLanguages
{
    public class Program
    {
        public static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
               
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
