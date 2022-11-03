using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string pattern = $@"[\d]+";

            char[] separators = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            StringBuilder finalResult = new StringBuilder();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            string[] splitedInput = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitedInput.Length; i++)
            {
                string currentText = splitedInput[i];

                int currentDigit = int.Parse(matches[i].Value);

                string currentResult = CurrentResult(currentText, currentDigit);

                finalResult.Append(currentResult);
            }
            List<char> symbols = finalResult.ToString().Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(finalResult.ToString());
        }

        static string CurrentResult(string currentText, int currentDigit)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= currentDigit; i++)
            {
                result.Append(currentText);
            }
            return result.ToString();
        }
    }
}