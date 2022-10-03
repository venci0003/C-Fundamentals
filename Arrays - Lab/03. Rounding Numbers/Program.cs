using System;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double[] numbers = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }
            for (int j = 0; j < input.Length; j++)
            {
                Console.WriteLine($"{numbers[j]} => {(int)Math.Round(numbers[j], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
