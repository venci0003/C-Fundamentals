using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.RemoveAll(numbers => numbers < 0);
            numbers.Reverse();
            if (numbers.Count != 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }
            Console.WriteLine("empty");
        }
    }
}
