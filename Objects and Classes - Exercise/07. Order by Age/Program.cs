using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] personToekns = command.Split(" ").ToArray();

                string name = personToekns[0];

                string id = personToekns[1];

                int age = int.Parse(personToekns[2]);

                Person person = new Person(name, id, age);

                Persons.Add(person);

            }
            foreach (Person person in Persons.OrderBy(person => person.Age))
            {
                Console.WriteLine(person);
            }

        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}