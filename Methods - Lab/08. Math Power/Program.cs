using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Power(@base, power);
        }
        static void Power(double @base, double power)
        {
            Console.WriteLine(Math.Pow(@base, power));
        }
    }
}
