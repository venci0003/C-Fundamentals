using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int openBrackets = 0;
            int closedBrackets = 0;
            for (int i = 1; i <= loops; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openBrackets++;
                }
                else if (input == ")")
                {
                    closedBrackets++;
                    if (openBrackets - closedBrackets != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (openBrackets == closedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}

