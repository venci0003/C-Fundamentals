using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int capacity = 255;
            int water = 0;
            int waterPoured = 0;
            for (int i = 1; i <= times; i++)
            {
                water = int.Parse(Console.ReadLine());
                if (water <= capacity)
                {
                    waterPoured += water;
                    capacity -= water;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine($"{waterPoured}");
        }
    }
}
