using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Add")
                {
                    int addWagonWithPassangers = int.Parse(tokens[1]);
                    trainWagons.Add(addWagonWithPassangers);
                }
                else
                {
                    int addPassengers = int.Parse(tokens[0]);
                    AddPassangersToTrain(addPassengers, maxCapacity, trainWagons);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", trainWagons));
        }

        static void AddPassangersToTrain(int addPassengers, int maxCapacity, List<int> trainWagons)
        {
            for (int i = 0; i < trainWagons.Count; i++)
            {
                int currentWagon = trainWagons[i];
                if (addPassengers + currentWagon <= maxCapacity)
                {
                    trainWagons[i] += addPassengers;
                    break;
                }
            }
        }
    }
}
