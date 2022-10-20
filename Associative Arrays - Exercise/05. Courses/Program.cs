using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesAndStudentsInformation = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split(" : ");

                string courseName = tokens[0];

                string studentName = tokens[1];

                if (!coursesAndStudentsInformation.ContainsKey(courseName))
                {
                    coursesAndStudentsInformation.Add(courseName, new List<string>());
                }
                if (coursesAndStudentsInformation.ContainsKey(courseName))
                {
                    coursesAndStudentsInformation[courseName].Add(studentName);
                }
            }
            foreach (var coursesInformation in coursesAndStudentsInformation)
            {
                string courseName = coursesInformation.Key;

                var students = coursesInformation.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (var studentInformation in students)
                {
                    Console.WriteLine($"-- {studentInformation}");
                }
            }
        }
    }
}
