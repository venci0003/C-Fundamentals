using System;

namespace _06._Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Mexico" || country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
