using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsInformation = new Dictionary<string, List<double>>();

            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();

                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsInformation.ContainsKey(studentName))
                {
                    studentsInformation.Add(studentName, new List<double>());
                }
                if (studentsInformation.ContainsKey(studentName))
                {
                    studentsInformation[studentName].Add(studentGrade);
                }
            }
            foreach (var student in studentsInformation)
            {
                string studentName = student.Key;

                double studentGrade = student.Value.Average();

                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {studentGrade:f2}");
                }
            }
        }
    }
}
