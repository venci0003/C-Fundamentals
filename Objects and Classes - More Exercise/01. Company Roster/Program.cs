using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                double salary = double.Parse(data[1]);
                string department = data[2];

                departments.Add(department);

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }
            string bestDepartment = string.Empty;
            double highestAvgSalary = double.MinValue;
            foreach (var item in departments)
            {
                double sum = 0;
                int count = 0;
                for (int i = 0; i < departments.Count; i++)
                {
                    if (employees[i].Department == item)
                    {
                        sum += employees[i].Salary;
                        count++;
                    }

                }
                double avg = sum / count;
                if (avg >= highestAvgSalary)
                {
                    highestAvgSalary = avg;
                    bestDepartment = item;
                }
            }
            List<Employee> bestEmployeeDepartment = employees
                .Where(e => e.Department == bestDepartment)
                .OrderByDescending(s => s.Salary)
                .ToList();
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var employee in bestEmployeeDepartment)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}