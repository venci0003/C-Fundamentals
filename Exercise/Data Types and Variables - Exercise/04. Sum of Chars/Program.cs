using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int charToInt = (int)symbol;
                sum += charToInt;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
