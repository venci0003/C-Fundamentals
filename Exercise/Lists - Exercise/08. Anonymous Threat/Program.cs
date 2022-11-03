using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x).ToList();

            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] commandDetails = command.Split(' ');
                switch (commandDetails[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commandDetails[1]);
                        int endIndex = int.Parse(commandDetails[2]);
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        else if (startIndex >= input.Count)
                        {
                            command = Console.ReadLine();
                            continue;
                        }

                        if (endIndex >= input.Count)
                        {
                            endIndex = input.Count - 1;
                        }

                        input = Merge(input, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(commandDetails[1]);
                        int partitions = int.Parse(commandDetails[2]);  // range 0 - 100
                        if (partitions == 0)
                        {
                            command = Console.ReadLine();
                            continue;
                        }

                        Divide(input, index, partitions);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', input));
        }

        private static void Divide(List<string> input, int indexOfElementToDivide, int partitions)
        {
            string elementToDivide = input[indexOfElementToDivide];
            string dividedElement = "";
            if (elementToDivide.Length % partitions != 0)
            {
                // when division CANNOT make equal parts
                int lengthOfPartitions = elementToDivide.Length / partitions;
                int lengthOfLastPartition = lengthOfPartitions + (elementToDivide.Length % partitions);
                for (int i = 0; i < partitions - 1; i++)
                {
                    dividedElement += elementToDivide.Substring(0, lengthOfPartitions);
                    dividedElement += " ";
                    elementToDivide = elementToDivide.Remove(0, lengthOfPartitions);
                }

                dividedElement += elementToDivide;
            }
            else
            {
                // when division CAN make equal parts
                int lengthOfPartitions = elementToDivide.Length / partitions;
                for (int i = 0; i < partitions; i++)
                {
                    dividedElement += elementToDivide.Substring(0, lengthOfPartitions);
                    dividedElement += " ";
                    elementToDivide = elementToDivide.Remove(0, lengthOfPartitions);
                }
            }


            // collect all parts
            List<string> result = input;

            result.RemoveAt(indexOfElementToDivide);
            result.InsertRange(indexOfElementToDivide, dividedElement
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList());

            input = result.ToList();
        }

        private static List<string> Merge(List<string> input, int startIndex, int endIndex)
        {
            List<string> merged = input;

            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                sb.Append(input[i]);
            }

            merged.RemoveRange(startIndex, endIndex - startIndex + 1);
            merged.Insert(startIndex, sb.ToString());

            return merged.ToList();
        }
    }
}
