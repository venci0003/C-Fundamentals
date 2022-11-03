using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            result.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    continue;
                }
                result.Append(text[i]);
            }
            Console.WriteLine(result);
        }
    }
}
