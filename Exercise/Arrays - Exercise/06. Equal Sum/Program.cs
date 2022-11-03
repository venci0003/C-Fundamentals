using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFind = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                int rightSum = 0;
                for (int k = numbers.Length - 1; k > i; k--)
                {
                    rightSum += numbers[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isFind = true;
                    break;
                }
            }
            if (!isFind)
            {
                Console.WriteLine("no");
            }
        }
    }
}
