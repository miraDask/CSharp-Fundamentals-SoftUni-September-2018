

namespace _08.CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var companiesInfo = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split(" -> ").ToArray();

                string companyName = data[0];
                string employeeId = data[1];

                List<string> employees = new List<string>();
                employees.Add(employeeId);

                if (!companiesInfo.ContainsKey(companyName))
                {
                    companiesInfo.Add(companyName, employees);
                }
                else if(!companiesInfo[companyName].Contains(employeeId))
                {
                    companiesInfo[companyName].Add(employeeId);
                }               
            }

            var result = companiesInfo.OrderBy(pair => pair.Key);
            

            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}");

                foreach (var value in pair.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
