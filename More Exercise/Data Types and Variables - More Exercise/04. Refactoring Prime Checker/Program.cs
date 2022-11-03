using System;

namespace _04._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            for (int i = 2; i <= loops; i++)
            {
                bool isPrime = true;
                for (int digit = 2; digit < i; digit++)
                {
                    if (i % digit == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                string result = isPrime.ToString();
                result = result.ToLower();
                Console.WriteLine("{0} -> {1}", i, result);
            }
        }
    }
}
