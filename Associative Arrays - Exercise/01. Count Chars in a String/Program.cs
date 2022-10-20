using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray().ToArray();
            Dictionary<char, int> charactersDictionary = new Dictionary<char, int>();
            foreach (var character in text)
            {
                if (character != ' ')
                {
                    if (!charactersDictionary.ContainsKey(character))
                    {
                        charactersDictionary.Add(character, 0);
                    }
                    charactersDictionary[character]++;
                }
            }
            foreach (var character in charactersDictionary)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
