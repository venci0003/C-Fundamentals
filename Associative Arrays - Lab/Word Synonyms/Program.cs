using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionaryList = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                string word = Console.ReadLine();
                string synonym=Console.ReadLine();
                if (dictionaryList.ContainsKey(word))
                {
                    dictionaryList[word].Add(synonym);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(synonym);
                    dictionaryList.Add(word,list);
                }
            }
            foreach (KeyValuePair<string,List<string>> item in dictionaryList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
