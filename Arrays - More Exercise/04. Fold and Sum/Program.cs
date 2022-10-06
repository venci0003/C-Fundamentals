using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] upperRow = new int[2 * k];
            int[] lowerRow = new int[2 * k];

            int counter = 0;
            for (int i = k; i < k * 3; i++) lowerRow[counter++] = input[i];
            counter = 0;
            for (int i = k - 1; i >= 0; i--) upperRow[counter++] = input[i];
            for (int i = 4 * k - 1; i >= 3 * k; i--) upperRow[counter++] = input[i];

            for (int i = 0; i < lowerRow.Length; i++) Console.Write(lowerRow[i] + upperRow[i] + " ");
        }
    }
}
