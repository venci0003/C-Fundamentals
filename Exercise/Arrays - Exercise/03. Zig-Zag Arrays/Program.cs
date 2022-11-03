using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int[] evenArray = new int[loops];
            int[] oddArray = new int[loops];
            for (int i = 0; i < loops; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    evenArray[i] = numbers[0];
                    oddArray[i] = numbers[1];
                }
                else
                {
                    evenArray[i] = numbers[1];
                    oddArray[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", evenArray));
            Console.WriteLine(string.Join(" ", oddArray));
        }
    }
}
