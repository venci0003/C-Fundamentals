using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            if (minutes > 59)
            {
                minutes -= 60;
                hours++;

            }
            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:0#}");

            //or 

            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //var time = new TimeSpan(hours, minutes + 30, 0);
            //Console.WriteLine($"{time:h\\:mm}");
        }
    }
}
