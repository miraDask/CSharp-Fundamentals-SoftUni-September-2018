namespace _04.SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

      //  public string Language { get; set; }

        public int Points { get; set; }

        public Student(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Dictionary<string, int> languagesSubmissionsCount = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] data = input.Split('-');

                string name = data[0];

                if (data[1] == "banned")
                {
                    if (students.Any(s => s.Name == name))
                    {
                        var bannedStudent = students.Find(s => s.Name == name);
                        students.Remove(bannedStudent);
                    }
                }
                else
                {
                    string language = data[1];
                    int points = int.Parse(data[2]);

                    if (!languagesSubmissionsCount.ContainsKey(language))
                    {
                        languagesSubmissionsCount.Add(language, 1);
                    }
                    else
                    {
                        languagesSubmissionsCount[language]++;
                    }

                    if (students.Any(s => s.Name == name))
                    {
                        var currentStudent = students.Find(s => s.Name == name);

                        if (currentStudent.Points < points)
                        {
                            currentStudent.Points = points;
                        }
                    }
                    else
                    {
                        students.Add(new Student(name,points));
                    }

                }

            }

            Console.WriteLine("Results:");

            foreach (var student in students.OrderByDescending(s => s.Points).ThenBy(st => st.Name))
            {
                Console.WriteLine($"{student.Name} | {student.Points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var pair in languagesSubmissionsCount.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
