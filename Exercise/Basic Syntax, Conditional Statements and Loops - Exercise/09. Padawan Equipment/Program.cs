using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumbersOfSabers = Math.Ceiling(studentCount * 1.10);
            double totalNumbersOfBelts = Math.Floor(studentCount / 6.0);
            double finalPriceForSabers = totalNumbersOfSabers * priceOfSaber;
            double finalPriceForRobes = studentCount * priceOfRobes;
            double finalPriceForBelts = (studentCount - totalNumbersOfBelts) * priceOfBelts;

            double totalFinalPrice = finalPriceForBelts + finalPriceForRobes + finalPriceForSabers;

            if (budget >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalFinalPrice - budget):f2}lv more.");
            }
        }
    }
}

