using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine().Split();
            string[] secondElements = Console.ReadLine().Split();
            for (int i = 0; i < firstElements.Length; i++)
            {
                for (int j = 0; j < secondElements.Length; j++)
                {
                    if (firstElements[i] == secondElements[j])
                    {
                        Console.Write($"{secondElements[j]} ");
                    }
                }
            }
        }
    }
}
