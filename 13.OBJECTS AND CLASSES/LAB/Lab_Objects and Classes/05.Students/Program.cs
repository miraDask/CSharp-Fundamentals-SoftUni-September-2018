
namespace _05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

     public class Program
    {
        public static void Main()
        {
            var studentsRegister = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] currentStudentData = input.Split(' ').ToArray();

                Student currentStudent = new Student();

                currentStudent.Name = currentStudentData[0];
                currentStudent.LastName = currentStudentData[1];
                currentStudent.Age = int.Parse(currentStudentData[2]);
                currentStudent.HomeTown = currentStudentData[3];

                studentsRegister.Add(currentStudent);

            }

            string town = Console.ReadLine();

            foreach (Student student in studentsRegister)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.Name} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
