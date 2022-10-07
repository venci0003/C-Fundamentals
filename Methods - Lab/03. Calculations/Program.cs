using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Calculate(command, firstNumber, secondNumber);
        }
        static void Calculate(string command, int firstNumber, int secondNumber)
        {
            if (command == "add")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (command == "divide")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
        }
    }
}
