using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimeter}{secondName}");
        }
    }
}
