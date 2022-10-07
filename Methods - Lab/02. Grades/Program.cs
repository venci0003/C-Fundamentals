using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            Check(a);
        }
        static void Check(double a)
        {
            if (a >= 2.00 && a <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (a >= 3.00 && a <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (a >= 3.50 && a <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (a >= 4.50 && a <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (a >= 5.50 && a <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
