using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            SmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        static void SmallestNumber(int firstNumber, int secondNumber, int thirdNumber) => Console.WriteLine(Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber)));
    }
}

