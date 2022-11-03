using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = FindResult(num);
            Console.WriteLine(result);
        }
        static int FindResult(int num)
        {
            int result = FindSumOfOdds(num) * FindSumOfEvens(num);
            return result;
        }
        static int FindSumOfOdds(int num)
        {
            int sumOfOdds = 0;
            while (num != 0)
            {
                int nextNum = num % 10;
                if (nextNum % 2 == 1)
                {
                    sumOfOdds += nextNum;
                }
                num -= nextNum;
                num /= 10;
            }
            return sumOfOdds;
        }
        static int FindSumOfEvens(int num)
        {
            int sumOfEvens = 0;
            while (num != 0)
            {
                int nextNum = num % 10;
                if (nextNum % 2 == 0)
                {
                    sumOfEvens += nextNum;
                }
                num -= nextNum;
                num /= 10;
            }
            return sumOfEvens;
        }
    }
}
