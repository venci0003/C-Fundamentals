using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    evenSum += number[i];
                }
                else
                {
                    oddSum += number[i];
                }
            }
            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
