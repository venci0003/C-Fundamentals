using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();

            Dictionary<string, int> newOrders = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split();

                if (input == "buy")
                {
                    break;
                }
                string nameOfProduct = tokens[0];

                double price = double.Parse(tokens[1]);

                int quantityOfProduct = int.Parse(tokens[2]);

                if (!orders.ContainsKey(nameOfProduct))
                {
                    orders.Add(nameOfProduct, price);

                    newOrders.Add(nameOfProduct, quantityOfProduct);
                }
                else if (orders.ContainsKey(nameOfProduct))
                {
                    orders[nameOfProduct] = price;

                    newOrders[nameOfProduct] += quantityOfProduct;
                }
            }
            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
