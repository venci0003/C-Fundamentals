using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }
            foreach (var item in people.OrderByDescending(x => x.Age))
            {
                Console.WriteLine($"{item.Name} {item.Age}");
                break;
            }
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}