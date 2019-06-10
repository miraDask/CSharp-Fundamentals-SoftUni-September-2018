
namespace _01.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }

        public double Salary { get; set; }

    }

    public class Department
    {
        public Department(string name)
        {
            EmployeeRegister = new List<Employee>();
            Salaries = new List<double>();
            Name = name;

        }
        public string Name { get; set; }

        public List<Employee> EmployeeRegister { get; set; }

        public List<double> Salaries { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            int limit = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            List<Department> departments = new List<Department>();


            for (int i = 0; i < limit; i++)
            {
                string[] employeeData = Console.ReadLine().Split().ToArray();

                string name = employeeData[0];
                double salary = double.Parse(employeeData[1]);
                string departmentName = employeeData[2];



                Employee currentEmployee = new Employee(name, salary);
                Department currentDepartment = new Department(departmentName);

                if (!departments.Any(d => d.Name == departmentName))
                {
                    currentDepartment.EmployeeRegister.Add(currentEmployee);
                    currentDepartment.Salaries.Add(salary);
                    departments.Add(currentDepartment);

                }
                else
                {
                    int indexOfDepartment = departments.FindIndex(d => d.Name == departmentName);
                    departments[indexOfDepartment].EmployeeRegister.Add(currentEmployee);
                    departments[indexOfDepartment].Salaries.Add(salary);
                }

            }

            double bestAverageSalary = 0;
            string bestDepartment = string.Empty;
            int bestDepartmentIndex = -1;

            foreach (Department department in departments)
            {
                double currentAverageSalarySum = department.Salaries.Average();

                if (currentAverageSalarySum > bestAverageSalary)
                {
                    bestAverageSalary = currentAverageSalarySum;
                    bestDepartment = department.Name;
                    bestDepartmentIndex = departments.FindIndex(d => d.Name == bestDepartment);
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            Department resultDepartment = departments[bestDepartmentIndex];

            foreach (var employee in resultDepartment.EmployeeRegister.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
