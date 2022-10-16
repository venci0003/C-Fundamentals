using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();

                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);
                cars.Add(car);
            }
            string type = Console.ReadLine();
            foreach (var car in cars.Where(x => x.Cargo.Type == type))
            {
                if (type == "fragile")
                {
                    if (car.Cargo.Weight < 1000)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
                else
                {
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }
    }
    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
