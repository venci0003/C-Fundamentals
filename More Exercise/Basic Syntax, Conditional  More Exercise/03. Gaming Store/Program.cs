using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = string.Empty;
            double totalSpent = 0.0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${balance:f2}");
                    break;
                }
                else if (input == "OutFall 4")
                {

                    if (balance >= 39.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                        totalSpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (input == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 15.99;
                        totalSpent += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 19.99;
                        totalSpent += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 59.99;
                        totalSpent += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 29.99;
                        totalSpent += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {

                    if (balance >= 39.99)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= 39.99;
                        totalSpent += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
