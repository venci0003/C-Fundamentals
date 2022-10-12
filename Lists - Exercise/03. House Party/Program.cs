using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            var partyList = new List<string>();
            for (int i = 0; i < loops; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                if (partyList.Contains(name) && input[2] == "going!")
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (partyList.Contains(name) && input[2] == "not")
                {
                    partyList.Remove(name);
                }
                else if (!partyList.Contains(name) && input[2] == "not")
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else
                {
                    partyList.Add(name);
                }
            }
            foreach (var name in partyList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
