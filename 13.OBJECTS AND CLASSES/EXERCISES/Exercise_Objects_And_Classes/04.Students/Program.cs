

namespace _04.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string firstName, string lastName, double degree)
        {
            FirsName = firstName;
            LastName = lastName;
            Degree = degree;

        }
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public double Degree { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                Student student = new Student(input[0], input[1], double.Parse(input[2]));

                students.Add(student);

            }

            foreach (Student student in students.OrderByDescending(s => s.Degree))
            {
                Console.WriteLine($"{student.FirsName} {student.LastName}: {student.Degree:f2}");
            }
        }
    }
}
