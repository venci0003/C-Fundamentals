using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Delete")
                {
                    int numbersToDelete = int.Parse(tokens[1]);
                    numbers.RemoveAll(elements => elements == numbersToDelete);
                }
                else if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
