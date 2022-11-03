using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int newIndex = random.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[newIndex];
                words[newIndex] = currentWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
