using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyInformation = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split(" -> ");

                string companyName = tokens[0];

                string eployeeId = tokens[1];

                if (!companyInformation.ContainsKey(companyName))
                {
                    companyInformation.Add(companyName, new List<string>());
                }
                if (companyInformation.ContainsKey(companyName))
                {
                    if (!companyInformation[companyName].Contains(eployeeId))
                    {
                        companyInformation[companyName].Add(eployeeId);
                    }
                }
            }
            foreach (var company in companyInformation)
            {
                string companyName = company.Key;

                var employee = company.Value;

                Console.WriteLine($"{companyName}");

                foreach (var employeeName in employee)
                {
                    Console.WriteLine($"-- {employeeName}");
                }
            }
        }
    }
}
