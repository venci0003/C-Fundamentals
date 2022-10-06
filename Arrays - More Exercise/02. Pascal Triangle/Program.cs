using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] newArray = new int[num + 1];
            int[] oldArray = new int[num + 1];

            newArray[1] = 1;
            Console.WriteLine(newArray[1]);

            for (int row = 1; row < num; row++)
            {
                for (int i = 1; i <= num; i++) oldArray[i] = newArray[i];

                for (int i = 1; i <= row + 1; i++)
                {
                    newArray[i] = oldArray[i - 1] + oldArray[i];
                    Console.Write(newArray[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
