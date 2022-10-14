using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input.Split();

                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    ItemQuantity = int.Parse(tokens[2]),
                    Item = new Item
                    {
                        Name = tokens[1],
                        Price = decimal.Parse(tokens[3]),
                    }
                };
                boxes.Add(box);
                input = Console.ReadLine();
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.PriceForABox).ToList();
            foreach (var box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}
