using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            if (command == "string")
            {
                string a = firstInput;
                string b = secondInput;
                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (command == "char")
            {
                char a = char.Parse(firstInput);
                char b = char.Parse(secondInput);
                char result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (command == "int")
            {
                double a = double.Parse(firstInput);
                double b = double.Parse(secondInput);
                double result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }
        static string GetMax(string a, string b)
        {
            string result = string.Empty;
            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
        static char GetMax(char a, char b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return (char)result;
        }
        static double GetMax(double a, double b)
        {
            double result = 0.0;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}
