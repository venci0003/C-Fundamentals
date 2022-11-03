using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double firstResult = FactorialNumber(firstNumber);
            double secondResult = FactorialNumber(secondNumber);
            Console.WriteLine($"{(firstResult / secondResult):f2}");
        }

        static double FactorialNumber(int firstNumber)
        {
            double result = 1;
            while (firstNumber != 1)
            {
                result *= firstNumber;
                firstNumber--;
            }
            return result;
        }
    }
}
