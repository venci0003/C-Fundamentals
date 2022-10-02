using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;

            while (input != "Start")
            {
                double inputMoney = double.Parse(input);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    money += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            double totalPrice = 0;

            while (input != "End")
            {

                if (input == "Nuts")
                {
                    totalPrice = 2;
                }
                else if (input == "Water")
                {
                    totalPrice = 0.7;
                }
                else if (input == "Crisps")
                {
                    totalPrice = 1.5;
                }
                else if (input == "Soda")
                {
                    totalPrice = 0.8;
                }
                else if (input == "Coke")
                {
                    totalPrice = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    input = Console.ReadLine();
                    continue;
                }
                if (money >= totalPrice)
                {
                    money -= totalPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
