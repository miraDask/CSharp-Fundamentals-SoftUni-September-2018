
namespace _06.Students2._0
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

                string firstName = currentStudentData[0];
                string lastName = currentStudentData[1];
                int age = int.Parse(currentStudentData[2]);
                string homeTown = currentStudentData[3];

                if (StudentExists(firstName, lastName, studentsRegister))
                {
                    Student student = GetStudent(studentsRegister, firstName, lastName);
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student currentStudent = new Student();

                    currentStudent.Name = firstName ;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.HomeTown = homeTown;

                    studentsRegister.Add(currentStudent);
                }



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

        private static Student GetStudent(List<Student> studentsRegister, string firstName, string lastName)
        {
            int index = -1;

            for (int i = 0; i < studentsRegister.Count; i++)
            {
                if (studentsRegister[i].Name == firstName && studentsRegister[i].LastName == lastName)
                {
                    index = i;
                    break;
                }
            }

            Student student = studentsRegister[index];
            return student;
        }

        private static bool StudentExists(string firstName, string lastName, List<Student> studentsRegister)
        {
            bool result = false;

            for (int i = 0; i < studentsRegister.Count; i++)
            {
              
                if (studentsRegister[i].Name == firstName && studentsRegister[i].LastName == lastName)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
