using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            string number = string.Empty;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[i + 1];
                if (firstNumber == secondNumber)
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        number = firstNumber.ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
