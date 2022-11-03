using System;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] studentInformation = input.Split();
                if (IsStudentExisting(studentInformation[0], studentInformation[1], studentsList))
                {
                    Student student = studentsList.Find(student => student.FirstName == studentInformation[0] && student.SecondName == studentInformation[1]);
                    student.Age = int.Parse(studentInformation[2]);
                    student.HomeTown = studentInformation[3];
                }
                else
                {
                    Student student = new Student
                    {
                        FirstName = studentInformation[0],
                        SecondName = studentInformation[1],
                        Age = int.Parse(studentInformation[2]),
                        HomeTown = studentInformation[3],
                    };
                    studentsList.Add(student);
                }
            }
            string cityName = Console.ReadLine();
            foreach (Student student in studentsList)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
                }
            }
        }
        static bool IsStudentExisting(string firstName, string secondName, List<Student> studentList)
        {
            foreach (var student in studentList)
            {
                if (student.FirstName == firstName && student.SecondName == secondName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}



