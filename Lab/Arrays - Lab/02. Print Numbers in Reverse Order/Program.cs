using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            string[] numbers = new string[loop];
            for (int i = 0; i < loop; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            Array.Reverse(numbers);
            foreach (string number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
