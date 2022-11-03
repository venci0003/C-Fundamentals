using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weekDay = int.Parse(Console.ReadLine());
            string[] dayOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (weekDay >= 1 && weekDay <= 7)
            {
                Console.WriteLine(dayOfWeek[weekDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
