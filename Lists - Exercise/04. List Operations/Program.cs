using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;

                string[] cmd = command.Split();

                switch (cmd[0])
                {
                    case "Add":
                        integers.Add(int.Parse(cmd[1]));
                        break;
                    case "Shift":
                        {
                            if (cmd[1] == "left")
                            {
                                int count = int.Parse(cmd[2]);
                                for (int i = 0; i < count; i++)
                                {
                                    int temp = integers[0];
                                    integers.Add(temp);
                                    integers.RemoveAt(0);
                                }
                            }
                            else
                            {
                                int count = int.Parse(cmd[2]);
                                for (int i = 0; i < count; i++)
                                {
                                    int temp = integers[integers.Count - 1];
                                    integers.Insert(0, temp);
                                    integers.RemoveAt(integers.Count - 1);
                                }
                            }
                            break;
                        }

                    case "Insert":
                        {
                            int num = int.Parse(cmd[1]);
                            int index = int.Parse(cmd[2]);
                            if (OutsideBound(integers, index))
                            {
                                integers.Insert(index, num);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                            break;
                        }

                    case "Remove":
                        {
                            int index = int.Parse(cmd[1]);
                            if (OutsideBound(integers, index))
                            {
                                integers.RemoveAt(index);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
        static bool OutsideBound(List<int> integers, int index)
        {
            if (index >= 0 && index <= integers.Count)
            {
                return true;
            }
            return false;
        }
    }
}
