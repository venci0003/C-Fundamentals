using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] character = new string[3];
            string word = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                character[i] = Console.ReadLine();
                word += character[i];
            }
            Console.WriteLine(word);
        }
    }
}
