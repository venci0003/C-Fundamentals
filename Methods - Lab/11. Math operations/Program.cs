using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            if (op == "/")
            {
                double result = Divide(a, b);
                Console.WriteLine(result);
            }
            else if (op == "*")
            {
                double result = Multiply(a, b);
                Console.WriteLine(result);
            }
            else if (op == "+")
            {
                double result = Addition(a, b);
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                double result = Subtract(a, b);
                Console.WriteLine(result);
            }
        }
        static double Divide(double a, double b)
        {
            double result = 0.0;
            result = a / b;
            return result;
        }
        static double Subtract(double a, double b)
        {
            double result = 0.0;
            result = a - b;
            return result;
        }
        static double Multiply(double a, double b)
        {
            double result = 0.0;
            result = a * b;
            return result;
        }
        static double Addition(double a, double b)
        {
            double result = 0.0;
            result = a + b;
            return result;
        }
    }
}
