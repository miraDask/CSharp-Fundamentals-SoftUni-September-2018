

namespace _07.StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();

            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                List<double> gradeList = new List<double>();
                gradeList.Add(grade);

                if (!studentsInfo.ContainsKey(name))
                {

                    studentsInfo.Add(name, gradeList);
                }
                else
                {
                    studentsInfo[name].Add(grade);
                }
            }

            var result = new Dictionary<string, double>();

            foreach (var kvp in studentsInfo)
            {
                double averageGrade = kvp.Value.Average();

                if (averageGrade >= 4.5)
                {
                    result.Add(kvp.Key, averageGrade);
                }
            }

            var output = result.OrderByDescending(pair => pair.Value);

            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
// zero test OK! NEED TO SUBMIT IN JUDGE.