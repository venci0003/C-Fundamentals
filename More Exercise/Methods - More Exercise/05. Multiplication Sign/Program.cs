using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            MultiplicationSign(firstNumber, secondNumber, thirdNumber);
        }
        static void MultiplicationSign(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] threeNumbers = { firstNumber, secondNumber, thirdNumber };
            bool isNegative = false;
            int negativeNumbersCounter = 0;
            foreach (int number in threeNumbers)
            {
                if (number == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                if (number < 0)
                {
                    negativeNumbersCounter++;
                    if (negativeNumbersCounter >= 2 && negativeNumbersCounter <= 2)
                    {
                        isNegative = false;
                    }
                    else
                    {
                        isNegative = true;
                    }
                }
            }
            Console.WriteLine(isNegative ? "negative " : "positive");
        }
    }
}
