using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string kegName = string.Empty;
            double radius = 0.0;
            int height = 0;
            double max = 0;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= times; i++)
            {
                kegName = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                double result = Math.PI * Math.Pow(radius, 2) * height;
                if (result > max)
                {
                    max = result;
                    biggestKeg = kegName;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
