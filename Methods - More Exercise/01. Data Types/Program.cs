using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DataTypes(input);
        }

        static void DataTypes(string input)
        {
            if (input == "int")
            {
                int intNumber = int.Parse(Console.ReadLine()) * 2;
                Console.WriteLine(intNumber);
            }
            else if (input == "real")
            {
                double doubleNumber = double.Parse(Console.ReadLine()) * 1.5;
                Console.WriteLine($"{doubleNumber:f2}");
            }
            else if (input == "string")
            {
                string text = Console.ReadLine();
                Console.WriteLine($"${text}$");
            }
        }
    }
}
