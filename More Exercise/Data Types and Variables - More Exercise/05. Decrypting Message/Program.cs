using System;

namespace _05._Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int loops = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < loops; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int charToInt = (int)(character) + key;
                char intToChar = (char)(charToInt);
                message += intToChar;
            }
            Console.WriteLine(message);
        }
    }
}
