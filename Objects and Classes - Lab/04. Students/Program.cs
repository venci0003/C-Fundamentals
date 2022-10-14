using System;
using System.Collections.Generic;

namespace _04._Students
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

                Student student = new Student
                {
                    FirstName = studentInformation[0],
                    SecondName = studentInformation[1],
                    Age = int.Parse(studentInformation[2]),
                    HomeTown = studentInformation[3],
                };
                studentsList.Add(student);
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
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
