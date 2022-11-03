using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{(pounds * 1.31M):f3}");
        }
    }
}
