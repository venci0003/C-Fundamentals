using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split();

                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double FuelConsumption = double.Parse(carData[2]);
                Car car = new Car(model, fuelAmount, FuelConsumption);
                cars.Add(car);
            }
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;

                string[] tokens = cmd.Split();
                string driveCommand = tokens[0];
                if (driveCommand == "Drive")
                {
                    string model = tokens[1];
                    double distanceTraveled = double.Parse(tokens[2]);
                    Car car = cars.Find(m => m.Model == model);
                    car.CheckIfFuelIsEnough(distanceTraveled);
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Traveled}");
            }
        }
    }
    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
        }
        public void CheckIfFuelIsEnough(double distance)
        {
            double fuelNeeded = FuelConsumption * distance;
            if (fuelNeeded <= FuelAmount)
            {
                FuelAmount -= fuelNeeded;
                Traveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double Traveled { get; set; }
    }
}