using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
