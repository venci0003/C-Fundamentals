using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstAxysX = double.Parse(Console.ReadLine());
            double firstAxysY = double.Parse(Console.ReadLine());
            double secondAxysX = double.Parse(Console.ReadLine());
            double secondAxysY = double.Parse(Console.ReadLine());
            ClosestPoint(firstAxysX, firstAxysY, secondAxysX, secondAxysY);
        }

        static void ClosestPoint(double firstAxysX, double firstAxysY, double secondAxysX, double secondAxysY)
        {
            double firstDistance = Math.Sqrt(Math.Pow(firstAxysY, 2) + Math.Pow(firstAxysX, 2));
            double secondDistance = Math.Sqrt(Math.Pow(secondAxysY, 2) + Math.Pow(secondAxysX, 2));

            if (firstDistance < secondDistance)
            {
                Console.WriteLine($"({firstAxysX}, {firstAxysY})");
            }
            else
            {
                Console.WriteLine($"({secondAxysX}, {secondAxysY})");
            }
        }
    }
}
