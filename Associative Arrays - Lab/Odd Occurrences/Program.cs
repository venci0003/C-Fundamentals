using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (!dictionary.ContainsKey(lowerCaseWord))
                {
                    dictionary.Add(lowerCaseWord, 1);
                }
                else
                {
                    dictionary[lowerCaseWord]+=1;
                }
            }
            string[]oddOrderedWords=dictionary.Where(item=>item.Value%2!=0).Select(item=>item.Key).ToArray();
            Console.WriteLine(String.Join(" ",oddOrderedWords));
        }
    }
}
