using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderCount = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0.0;
            int daysInMonth = 0;
            int capsulesCount = 0;
            double result = 0;
            double totalPrice = 0.0;
            for (int i = 1; i <= orderCount; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                result = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += result;
                Console.WriteLine($"The price for the coffee is: ${result:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
