using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < loops; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            int counter = 1;
            foreach (string product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
