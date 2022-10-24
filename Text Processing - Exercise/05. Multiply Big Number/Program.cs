using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber == 0)
            {
                Console.WriteLine(0);

                return;
            }
            StringBuilder finalSum = new StringBuilder();

            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                char currentNumber = firstNumber[i];

                int currentNumberToInt = int.Parse(currentNumber.ToString());

                int result = currentNumberToInt * secondNumber + remainder;

                finalSum.Append(result % 10);

                remainder = result / 10;
            }
            if (remainder != 0)
            {
                finalSum.Append(remainder);
            }
            StringBuilder reversedString = new StringBuilder();

            for (int i = finalSum.Length - 1; i >= 0; i--)
            {
                reversedString.Append(finalSum[i]);
            }

            Console.WriteLine(reversedString);
        }
    }
}

