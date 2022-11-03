using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesAndQuantity = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (resourcesAndQuantity.ContainsKey(input))
                {
                    resourcesAndQuantity[input] += quantity;
                }
                else
                {
                    resourcesAndQuantity.Add(input, quantity);
                }
            }
            foreach (var resourceInformation in resourcesAndQuantity)
            {
                Console.WriteLine($"{resourceInformation.Key} -> {resourceInformation.Value}");
            }
        }
    }
}
