using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, CharacterProperties> dictionary = new Dictionary<char, CharacterProperties>();

            string[] input = Console.ReadLine().Split('|');

            string capitalLettersPattern = @"(\$|\%|\*|\&|\#)(?<capitalLetters>[A-Z]+)\1";

            Regex regex = new Regex(capitalLettersPattern);

            string digitAndLenghtPattern = @"(?<position>[0-9]([0-9])*)\:(?<lenght>[0-9][0-9])";

            Regex digit = new Regex(digitAndLenghtPattern);

            MatchCollection capitalLetters = regex.Matches(input[0]);

            MatchCollection digits = digit.Matches(input[1]);

            FindValidLettersLenght(capitalLetters, digits, input[0], dictionary);

            FindMatchingWords(dictionary, input[2]);

            PrintResult(dictionary);
        }
        static void PrintResult(Dictionary<char, CharacterProperties> dictionary)
        {
            foreach (KeyValuePair<char, CharacterProperties> word in dictionary)
            {
                Console.WriteLine(String.Join(Environment.NewLine, word.Value.Words));
            }
        }

        static void FindMatchingWords(Dictionary<char, CharacterProperties> dictionary, string thirdPart)
        {
            string[] arrayOfWords = thirdPart.Split(' ');

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                string currentWord = arrayOfWords[i];

                char firstLetter = currentWord[0];

                if (dictionary.ContainsKey(firstLetter))
                {
                    if (currentWord.Length == dictionary[firstLetter].Lenght)
                    {
                        dictionary[firstLetter].Words.Add(currentWord);
                    }
                }
            }
        }

        static void FindValidLettersLenght(MatchCollection capitalLetters, MatchCollection digits, string input, Dictionary<char, CharacterProperties> dictionary)
        {
            foreach (Match letter in capitalLetters)
            {
                char[] array = letter.Value.ToCharArray();

                foreach (char valueLetter in array)
                {
                    foreach (Match item in digits)
                    {
                        int result = 0;

                        int asciCode = int.Parse(item.Groups["position"].Value);

                        string secondLength = item.Groups["lenght"].Value;

                        if (secondLength[0] == '0')
                        {
                            result = int.Parse(secondLength[1].ToString());
                        }
                        else
                        {
                            result = int.Parse(secondLength);
                        }
                        result++;
                        int counter = 0;
                        if (char.IsLetter(valueLetter))
                        {
                            if (asciCode == (int)(valueLetter))
                            {
                                if (!dictionary.ContainsKey(valueLetter))
                                {
                                    CharacterProperties currentProperties = new CharacterProperties(result);
                                    dictionary[valueLetter] = currentProperties;
                                    counter++;
                                }
                            }
                        }
                        if (counter > 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
        class CharacterProperties
        {
            public CharacterProperties(int length)
            {
                this.Lenght = length;
                Words = new List<string>();
            }
            public int Lenght { get; set; }
            public List<string> Words { get; set; } = new List<string>();
        }
    }
}
