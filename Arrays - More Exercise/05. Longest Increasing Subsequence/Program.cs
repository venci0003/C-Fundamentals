using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] index = new int[nums.Length];

            int maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i] && index[j] > index[i] - 1)
                    {
                        index[i] = index[j] + 1;
                        if (index[i] > index[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                }
            }

            Print(maxIndex, nums, index);
        }

        static void Print(int maxIndex, int[] nums, int[] index)
        {
            bool isFirst = true;
            for (int i = 0; i < maxIndex; i++)
            {
                if (nums[i] < nums[maxIndex] && index[i] == index[maxIndex] - 1 && isFirst)
                {
                    isFirst = false;
                    Print(i, nums, index);
                }
            }

            Console.Write(nums[maxIndex] + " ");
        }
    }
}
