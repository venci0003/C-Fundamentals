using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bombPlace = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int explosion = 0;
            for (int i = 0; i < bombPlace.Length; i++)
            {
                char currentCharacter = bombPlace[i];
                if (currentCharacter == '>')
                {
                    explosion += int.Parse(bombPlace[i + 1].ToString());
                    result.Append(currentCharacter);
                }
                else if (explosion == 0)
                {
                    result.Append(currentCharacter);
                }
                else
                {
                    explosion--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
