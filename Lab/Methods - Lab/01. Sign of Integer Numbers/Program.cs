using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SignOfInteger(number));
        }
        static string SignOfInteger(int number)
        {
            string result = string.Empty;
            if (number > 0)
            {
                result = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                result = $"The number {number} is negative. ";
            }
            if (number == 0)
            {
                result = $"The number {number} is zero.";
            }
            return result;
        }
    }
}
