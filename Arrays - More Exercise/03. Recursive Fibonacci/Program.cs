using System;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(input));
        }

        static int GetFibonacci(int n)
        {
            if (n == 2 || n == 1) return 1;
            int number = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            return number;
        }
    }
}
