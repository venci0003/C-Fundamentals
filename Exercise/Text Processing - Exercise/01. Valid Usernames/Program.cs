using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder validUsernames = new StringBuilder();

            foreach (var username in usernames)
            {
                bool isUsernameValid = true;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    for (int i = 0; i < username.Length; i++)
                    {
                        char currentCharacterInUsername = username[i];

                        if (!(currentCharacterInUsername == '-' || currentCharacterInUsername == '_' || char.IsLetterOrDigit(currentCharacterInUsername)))
                        {
                            isUsernameValid = false;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}