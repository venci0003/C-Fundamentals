using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
