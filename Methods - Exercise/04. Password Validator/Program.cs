using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool ValidPasswordLenght = IsValidPasswordLenght(password);
            bool ValidPasswordCointainsLettersandDigits = CheckIfPasswordCointainsLettersandDigits(password);
            bool ValidPasswordDigits = CheckIfPasswordContainsTwoDigits(password);

            if (!ValidPasswordLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ValidPasswordCointainsLettersandDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ValidPasswordDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (ValidPasswordLenght && ValidPasswordCointainsLettersandDigits && ValidPasswordDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckIfPasswordContainsTwoDigits(string password)
        {
            int counter = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }
            return counter >= 2;
        }

        static bool CheckIfPasswordCointainsLettersandDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsValidPasswordLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
