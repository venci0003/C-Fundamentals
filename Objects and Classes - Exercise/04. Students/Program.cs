using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countStudents; i++)
            {
                string studentsInformation = Console.ReadLine();

                string[] studentsTokens = studentsInformation.Split(' ');

                Students student = new Students(studentsTokens[0], studentsTokens[1], double.Parse(studentsTokens[2]));

                students.Add(student);
            }
            List<Students> sortedStudents = students.OrderByDescending(student => student.Grades).ToList();

            foreach (Students student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grades:f2}");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grades = grades;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grades { get; set; }
    }
}
