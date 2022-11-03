using System;

namespace _02._English_Name_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastNumber = number % 10;

            string lastDigitName = 
                lastNumber == 1 ? "one"  : 
                lastNumber == 2 ? "two"  : 
                lastNumber == 3 ? "three": 
                lastNumber == 4 ? "four" : 
                lastNumber == 5 ? "five" : 
                lastNumber == 6 ? "six"  : 
                lastNumber == 7 ? "seven": 
                lastNumber == 8 ? "eight": 
                lastNumber == 9 ? "nine" : "zero";

            Console.WriteLine(lastDigitName);
        }
    }
}
