using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');

            string firstIndexOfText = text[0];

            string secondIndexOfText = text[1];

            Console.WriteLine(CharMultiplier(firstIndexOfText, secondIndexOfText));
        }

        static int CharMultiplier(string firstIndexOfText, string secondIndexOfText)
        {
            int sum = 0;

            if (firstIndexOfText.Length > secondIndexOfText.Length)
            {
                for (int i = 0; i < secondIndexOfText.Length; i++)
                {
                    sum += firstIndexOfText[i] * secondIndexOfText[i];
                }
                for (int i = secondIndexOfText.Length; i < firstIndexOfText.Length; i++)
                {
                    sum += firstIndexOfText[i];
                }
            }
            else
            {
                for (int i = 0; i < firstIndexOfText.Length; i++)
                {
                    sum += firstIndexOfText[i] * secondIndexOfText[i];
                }
                for (int i = firstIndexOfText.Length; i < secondIndexOfText.Length; i++)
                {
                    sum += secondIndexOfText[i];
                }
            }

            return sum;
        }
    }
}
