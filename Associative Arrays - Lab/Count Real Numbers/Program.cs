using System;
using System.Linq;
using System.Collections.Generic;
namespace Associative_Arrays___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(number=>int.Parse(number)).ToList();
            SortedDictionary<int,int> dictionary=new SortedDictionary<int,int>();
            foreach (int number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1);
                }
                else
                {
                    dictionary[number]++;
                }
            }
            foreach (KeyValuePair<int,int> item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
