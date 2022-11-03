using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string input = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 1; i <= 4; i++)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                if (i == 3)
                {
                    break;
                }
            }
            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
