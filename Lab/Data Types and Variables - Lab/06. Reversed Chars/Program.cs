using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = Console.ReadLine();
            }
            for (int i = 2; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
