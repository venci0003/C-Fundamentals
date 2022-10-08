using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            RangeInCharacters(firstCharacter, secondCharacter);
        }

        static void RangeInCharacters(char firstCharacter, char secondCharacter)
        {
            int startingCharacter = Math.Min(firstCharacter, secondCharacter);
            int endCharacter = Math.Max(firstCharacter, secondCharacter);
            for (int i = startingCharacter + 1; i < endCharacter; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
