using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VechicleCatalogue> vechicles = new List<VechicleCatalogue>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ");

                string type = tokens[0];

                TypeVechicle typeVehicle;

                bool isVehicle = Enum.TryParse(type, true, out typeVehicle);

                if (isVehicle)
                {
                    string model = tokens[1];

                    string color = tokens[2];

                    int horsePower = int.Parse(tokens[3]);

                    VechicleCatalogue vechicle = new VechicleCatalogue(typeVehicle, model, color, horsePower);

                    vechicles.Add(vechicle);
                }
            }
            string command2 = string.Empty;

            while ((command2 = Console.ReadLine()) != "Close the Catalogue")
            {
                VechicleCatalogue vechicle = vechicles.FirstOrDefault(vechicleModel => vechicleModel.Model == command2);

                Console.Write(vechicle);
            }
            List<VechicleCatalogue> cars = vechicles
                .Where(vechicle1 => vechicle1.Type == TypeVechicle.Car)
                .ToList();

            List<VechicleCatalogue> truck = vechicles
                .Where(vehicle1 => vehicle1.Type == TypeVechicle.Truck)
                .ToList();

            if (cars.Count > 0)
            {
                double carsHorsePower = cars.Average(car => car.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {carsHorsePower:f2}.");
            }
            else
            {
                double carsHorsePower = 0;
                Console.WriteLine($"Cars have average horsepower of: {carsHorsePower:f2}.");
            }
            if (truck.Count > 0)
            {
                double trucksHorePower = truck.Average(truck => truck.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorePower:f2}.");
            }
            else
            {
                double trucksHorePower = 0;
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorePower:f2}.");
            }
        }
    }
    enum TypeVechicle
    {
        Car,
        Truck,
    }
    class VechicleCatalogue
    {
        public VechicleCatalogue(TypeVechicle type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public TypeVechicle Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public override string ToString()
        {
            StringBuilder props = new StringBuilder();
            props.AppendLine($"Type: {Type}");
            props.AppendLine($"Model: {Model}");
            props.AppendLine($"Color: {Color}");
            props.AppendLine($"Horsepower: {HorsePower}");
            return props.ToString();
        }
    }
}
