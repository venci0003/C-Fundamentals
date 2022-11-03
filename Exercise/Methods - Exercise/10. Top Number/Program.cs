using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);
        }
        static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (GetOddNum(i) && IsDivisibleByEight(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool GetOddNum(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                    return true;
                number /= 10;
            }
            return false;
        }
        static bool IsDivisibleByEight(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }
            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
