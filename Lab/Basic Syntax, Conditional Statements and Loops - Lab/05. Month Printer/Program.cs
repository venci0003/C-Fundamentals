using System;

namespace _05._Month_Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            switch (input)
            {
                case 1:
                    Console.WriteLine(months[0]);
                    break;
                case 2:
                    Console.WriteLine(months[1]);
                    break;
                case 3:
                    Console.WriteLine(months[2]);
                    break;
                case 4:
                    Console.WriteLine(months[3]);
                    break;
                case 5:
                    Console.WriteLine(months[4]);
                    break;
                case 6:
                    Console.WriteLine(months[5]);
                    break;
                case 7:
                    Console.WriteLine(months[6]);
                    break;
                case 8:
                    Console.WriteLine(months[7]);
                    break;
                case 9:
                    Console.WriteLine(months[8]);
                    break;
                case 10:
                    Console.WriteLine(months[9]);
                    break;
                case 11:
                    Console.WriteLine(months[10]);
                    break;
                case 12:
                    Console.WriteLine(months[11]);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}

