using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split();
                string action = tokens[0];
                if (action == "Add")
                {
                    int addNumbers = int.Parse(tokens[1]);
                    list.Add(addNumbers);
                }
                if (action == "Remove")
                {
                    int removeNumbers = int.Parse(tokens[1]);
                    list.Remove(removeNumbers);
                }
                if (action == "RemoveAt")
                {
                    int removeNumbers = int.Parse(tokens[1]);
                    list.RemoveAt(removeNumbers);
                }
                if (action == "Insert")
                {
                    int numberInsert = int.Parse(tokens[1]);
                    int numberIndex = int.Parse(tokens[2]);
                    list.Insert(numberIndex, numberInsert);
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
