using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfPeople = double.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double money = 0.0;
            if (typeGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    money = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    money = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    money = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    money = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    money = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    money = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    money = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    money = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    money = 22.50;
                }
            }

            double moneySum = 0;

            if (typeGroup == "Students" && amountOfPeople >= 30)
            {
                moneySum = money * amountOfPeople;
                moneySum *= 0.85;
            }
            else if (typeGroup == "Business" && amountOfPeople >= 100)
            {
                amountOfPeople -= 10;
                moneySum = money * amountOfPeople;
            }
            else if (typeGroup == "Regular" && amountOfPeople >= 10 && amountOfPeople <= 20)
            {
                moneySum = money * amountOfPeople;
                moneySum *= 0.95;
            }
            else
            {
                moneySum = money * amountOfPeople;
            }
            Console.WriteLine($"Total price: {moneySum:f2}");
        }
    }
}
