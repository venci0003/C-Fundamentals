using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] command = input.Split(":");

                list = SoftUniCoursePlanning(list, command);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }

        static List<string> SoftUniCoursePlanning(List<string> list, string[] command)
        {
            switch (command[0])
            {
                case "Add": list = Add(list, command); break;
                case "Insert": list = Insert(list, command); break;
                case "Remove": list = Remove(list, command); break;
                case "Swap": list = Swap(list, command); break;
                case "Exercise": list = Exercise(list, command); break;
                default:
                    break;
            }

            return list;
        }

        static List<string> Exercise(List<string> list, string[] command)
        {
            string lessonTitle = command[1];

            if (list.Contains(lessonTitle) && !list.Contains(lessonTitle + "-Exercise"))
            {
                int index = list.IndexOf(lessonTitle);
                list.Insert(index + 1, lessonTitle + "-Exercise");
            }
            else if (!list.Contains(lessonTitle))
            {
                list.Add(lessonTitle);
                list.Add(lessonTitle + "-Exercise");
            }

            return list;
        }

        static List<string> Swap(List<string> list, string[] command)
        {
            string lessonTitle1 = command[1];
            string lessonTitle2 = command[2];
            int index1 = list.IndexOf(lessonTitle1);
            int index2 = list.IndexOf(lessonTitle2);

            if (list.Contains(lessonTitle1) && list.Contains(lessonTitle2))
            {
                string tempLessonTitle1 = list.ElementAt(index1);
                list[index1] = list[index2];
                list[index2] = tempLessonTitle1;
            }

            if (list.Contains(lessonTitle1 + "-Exercise") && list.Contains(list[index1]))
            {
                index1 = list.IndexOf(lessonTitle1);
                list.Remove(lessonTitle1 + "-Exercise");
                list.Insert(index1 + 1, lessonTitle1 + "-Exercise");
            }
            else if (list.Contains(lessonTitle2 + "-Exercise") && list.Contains(list[index2]))
            {
                index2 = list.IndexOf(lessonTitle2);
                list.Remove(lessonTitle2 + "-Exercise");
                list.Insert(index2 + 1, lessonTitle2 + "-Exercise");
            }

            return list;
        }

        static List<string> Remove(List<string> list, string[] command)
        {
            string lessonTitle = command[1];

            if (list.Contains(lessonTitle))
            {
                list.Remove(lessonTitle);
            }
            else if (list.Contains(lessonTitle + "-Exercise"))
            {
                list.Remove(lessonTitle + "-Exercise");
            }

            return list;
        }

        static List<string> Insert(List<string> list, string[] command)
        {
            string lessonTitle = command[1];
            int index = int.Parse(command[2]);

            if (index < 0 || index >= list.Count)
            {
                return list;
            }
            else if (!list.Contains(lessonTitle))
            {
                list.Insert(index, lessonTitle);
            }

            return list;
        }

        static List<string> Add(List<string> list, string[] command)
        {
            string lessonTitle = command[1];

            if (!list.Contains(lessonTitle))
            {
                list.Add(lessonTitle);
            }

            return list;
        }
    }
}
