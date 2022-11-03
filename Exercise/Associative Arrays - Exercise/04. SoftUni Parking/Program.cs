using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLoops = int.Parse(Console.ReadLine());

            Dictionary<string, string> dataBaseOfRegistrations = new Dictionary<string, string>();

            for (int i = 0; i < countOfLoops; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split();

                string registrationCommand = tokens[0];

                string username = tokens[1];

                if (registrationCommand == "register" && dataBaseOfRegistrations.ContainsKey(username))
                {
                    string licensePlateNumber = tokens[2];

                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                }
                if (registrationCommand == "register" && !dataBaseOfRegistrations.ContainsKey(username))
                {
                    string licensePlateNumber = tokens[2];

                    dataBaseOfRegistrations.Add(username, licensePlateNumber);

                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
                if (registrationCommand == "unregister" && !dataBaseOfRegistrations.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                if (registrationCommand == "unregister" && dataBaseOfRegistrations.ContainsKey(username))
                {
                    dataBaseOfRegistrations.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
            foreach (var registration in dataBaseOfRegistrations)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
