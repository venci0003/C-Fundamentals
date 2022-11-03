using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\!(?<behavior>[G|N]{1})\!";

            Regex regex = new Regex(pattern);

            List<string> goodChildren = new List<string>();

            int key = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string decryptedMessage = DecryptMessage(command, key);

                Match match = regex.Match(decryptedMessage);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;

                    char behavior = char.Parse(match.Groups["behavior"].Value);

                    if (behavior == 'G')
                    {
                        goodChildren.Add(name);
                    }
                }
            }
            PrintResult(goodChildren);
        }

        static void PrintResult(List<string> goodChilder)
        {
            foreach (string name in goodChilder)
            {
                Console.WriteLine(name);
            }
        }

        static string DecryptMessage(string command, int key)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < command.Length; i++)
            {
                char currentLetter = command[i];

                char newLetter = (char)(currentLetter - key);

                result.Append(newLetter);
            }
            return result.ToString();
        }
    }
}
