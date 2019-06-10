using System;
using System.Globalization;

namespace _14.test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }
}
