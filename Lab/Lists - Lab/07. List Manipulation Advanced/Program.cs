using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            bool isListChanged = false;
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
                    isListChanged = true;
                }
                if (action == "Remove")
                {
                    int removeNumbers = int.Parse(tokens[1]);
                    list.Remove(removeNumbers);
                    isListChanged = true;
                }
                if (action == "RemoveAt")
                {
                    int removeNumbers = int.Parse(tokens[1]);
                    list.RemoveAt(removeNumbers);
                    isListChanged = true;
                }
                if (action == "Insert")
                {
                    int numberInsert = int.Parse(tokens[1]);
                    int numberIndex = int.Parse(tokens[2]);
                    list.Insert(numberIndex, numberInsert);
                    isListChanged = true;
                }
                if (action == "Contains")
                {

                    if (list.Contains(int.Parse(tokens[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (action == "PrintEven")
                {
                    foreach (int number in list)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }

                }
                if (action == "PrintOdd")
                {
                    foreach (int number in list)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                }
                if (action == "GetSum")
                {
                    Console.WriteLine(list.Sum());
                }
                if (action == "Filter")
                {
                    Filter(tokens[1], int.Parse(tokens[2]), list);
                }
            }
            if (isListChanged)
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }

        static void Filter(string v1, int v2, List<int> list)
        {
            if (v1 == "<")
            {
                foreach (var number in list)
                {
                    if (number < v2)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            if (v1 == "<=")
            {
                foreach (var number in list)
                {
                    if (number <= v2)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            if (v1 == ">")
            {
                foreach (var number in list)
                {
                    if (number > v2)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            if (v1 == ">=")
            {
                foreach (var number in list)
                {
                    if (number >= v2)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
