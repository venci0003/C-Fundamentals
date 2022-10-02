using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int space = 0;
            string left = string.Empty;
            string right = string.Empty;
            for (int i = 1; i <= loops; i++)
            {
                string text = Console.ReadLine();
                for (int j = 0; j < text.Length - 1; j++)
                {
                    if (text[j] == ' ')
                    {
                        space = j;
                    }
                }
                left = text.Substring(0, space);
                BigInteger leftToNum = BigInteger.Parse(left);
                right = text.Substring(space + 1);
                BigInteger rightToNum = BigInteger.Parse(right);
                if (leftToNum > rightToNum)
                {
                    BigInteger leftSum = 0;
                    if (leftToNum < 0)
                    {
                        leftToNum = BigInteger.Abs(leftToNum);
                    }
                    while (leftToNum > 0)
                    {
                        BigInteger digit = leftToNum % 10;
                        leftSum += digit;
                        leftToNum /= 10;
                    }
                    Console.WriteLine($"{leftSum}");
                }
                else
                {
                    BigInteger rightSum = 0;
                    if (rightToNum < 0)
                    {
                        rightToNum = BigInteger.Abs(rightToNum);
                    }
                    while (rightToNum > 0)
                    {
                        BigInteger digit = rightToNum % 10;
                        rightSum += digit;
                        rightToNum /= 10;
                    }
                    Console.WriteLine($"{rightSum}");
                }
            }
        }
    }
}
