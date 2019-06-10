
namespace _06.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            var courseData = new Dictionary<string, List<string>>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }


                string[] currentData = input.Split(" : ").ToArray();
                List<string> studentList = new List<string>();
                string course = currentData[0];
                string studentName = currentData[1];

                studentList.Add(studentName);

                if (!courseData.ContainsKey(course))
                {

                    courseData.Add(course, studentList);
                }
                else
                {
                    courseData[course].Add(studentName);
                }

                courseData[course].Sort();
            }

            
            var result = courseData.OrderByDescending(pair => pair.Value.Count);
            

            foreach (var kvp in result)
            {
                
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var name in kvp.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }

        
    }
}
