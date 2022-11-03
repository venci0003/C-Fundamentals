using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool ifTrue = false;
            for (int i = 1; i <= times; i++)
            {
                num = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                ifTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{num} -> {ifTrue}");
                sum = 0;
                i = num;
            }
        }
    }
}
