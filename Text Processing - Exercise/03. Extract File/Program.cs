using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine().Split('\\').ToArray();

            string[] pathToFileInformation = directory[directory.Length - 1].Split('.').ToArray();

            Console.WriteLine($"File name: {pathToFileInformation[0]}\nFile extension: {pathToFileInformation[1]}");

        }
    }
}
