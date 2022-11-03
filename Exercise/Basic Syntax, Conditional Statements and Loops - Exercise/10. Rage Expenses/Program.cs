using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double brokenHeadsets = (lostGames / 2) * headsetPrice;
            double brokenMouses = (lostGames / 3) * mousePrice;
            double brokenKeyboards = (lostGames / 6) * keyboardPrice;
            double brokenDisplays = (lostGames / 12) * displayPrice;

            double expenses = brokenKeyboards + brokenMouses + brokenHeadsets + brokenDisplays;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
