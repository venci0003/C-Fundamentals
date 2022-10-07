using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = Word(word, times);
            Console.WriteLine(result);
        }
        private static string Word(string a, int b)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < b; i++)
            {
                result.Append(a);
            }
            return result.ToString();
        }
    }
}
