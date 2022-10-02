using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int dayCounter = 0;
            int sum = 0;
            int produced = 0;
            while (yield >= 100)
            {
                produced = yield;
                dayCounter++;
                produced -= 26;
                sum += produced;
                yield -= 10;
            }
            if (sum >= 26)
            {
                sum -= 26;
            }
            Console.WriteLine($"{dayCounter}\n{sum}");
        }
    }
}
