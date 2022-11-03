using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            if (option == "coffee")
            {
                Coffee(a);
            }
            else if (option == "water")
            {
                Water(a);
            }
            else if (option == "coke")
            {
                Coke(a);
            }
            else if (option == "snacks")
            {
                Snacks(a);
            }
        }
        static void Coffee(double a)
        {
            Console.WriteLine($"{(1.50 * a):f2}");
        }
        static void Water(double a)
        {
            Console.WriteLine($"{(1.00 * a):f2}");
        }
        static void Coke(double a)
        {
            Console.WriteLine($"{(1.40 * a):f2}");
        }
        static void Snacks(double a)
        {
            Console.WriteLine($"{(2.00 * a):f2}");
        }
    }
}
