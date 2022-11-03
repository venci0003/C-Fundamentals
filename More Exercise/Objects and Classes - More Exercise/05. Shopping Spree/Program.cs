using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in peopleInput)
            {
                string[] spl = item.Split('=');
                Person person = new Person(spl[0], int.Parse(spl[1]));
                people.Add(person);
            }
            foreach (var item in productInput)
            {
                string[] spl = item.Split('=');
                Product product = new Product(spl[0], int.Parse(spl[1]));
                products.Add(product);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") break;

                string[] tokens = input.Split();

                string name = tokens[0];
                string productName = tokens[1];
                Person person = people.Find(x => x.Name == name);
                Product product = products.Find(x => x.ItemName == productName);
                if (person.Money - product.Cost >= 0)
                {
                    person.Money -= product.Cost;
                    person.Bag.Add(product);
                    Console.WriteLine($"{person.Name} bought {product.ItemName}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.ItemName}");
                }
            }
            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.Bag.Count > 0)
                {
                    List<string> itemNames = new List<string>();
                    foreach (var item in person.Bag)
                    {
                        itemNames.Add(item.ItemName);
                    }
                    Console.WriteLine($"{string.Join(", ", itemNames)}");
                }
                else
                {
                    Console.WriteLine($"Nothing bought");
                }
            }
        }
    }
    class Person
    {
        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            Bag = new List<Product>();
        }

        public string Name { get; set; }
        public int Money { get; set; }
        public List<Product> Bag { get; set; }

    }
    class Product
    {
        public Product(string itemName, int cost)
        {
            ItemName = itemName;
            Cost = cost;
        }

        public string ItemName { get; set; }
        public int Cost { get; set; }
    }
}