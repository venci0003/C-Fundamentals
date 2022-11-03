using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];

                char lastLetter = item[item.Length - 1];

                double number = double.Parse(item.Substring(1, item.Length - 2));


                double result = 0;

                if (char.IsUpper(firstLetter))
                {
                    double firstLetterPositionAlphabet = firstLetter - 64;

                    result = number / firstLetterPositionAlphabet;
                }
                else
                {
                    double firstLetterPositionAlphabet = firstLetter - 96;

                    result = number * firstLetterPositionAlphabet;
                }

                if (char.IsUpper(lastLetter))
                {
                    double lastLetterPositionAlphabet = lastLetter - 64;

                    result = result - lastLetterPositionAlphabet;
                }
                else
                {
                    double lastLetterPositionAlphabet = lastLetter - 96;

                    result = result + lastLetterPositionAlphabet;
                }
                sum += result;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
