using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VowelsCheck(word);
        }
        static void VowelsCheck(string word)
        {
            Console.WriteLine(word.Count(vowel => "auoei".Contains(vowel)));
        }
    }
}
