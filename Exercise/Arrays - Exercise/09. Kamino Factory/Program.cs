using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] lss = new int[length];
            int lssLength = int.MinValue, lssIndex = int.MinValue, lssSum = int.MinValue, lssStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > lssLength)
                {
                    lssLength = currentLength;
                    lssIndex = currentIndex;
                    lssSum = data.Sum();
                    lss = data;
                    lssStart = index;
                }
                else if (currentLength == lssLength)
                {
                    if (currentIndex < lssIndex)
                    {
                        lssLength = currentLength;
                        lssIndex = currentIndex;
                        lssSum = data.Sum();
                        lss = data;
                        lssStart = index;
                    }
                    else if (currentIndex == lssIndex)
                    {
                        if (data.Sum() > lssSum)
                        {
                            lssLength = currentLength;
                            lssIndex = currentIndex;
                            lssSum = data.Sum();
                            lss = data;
                            lssStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {lssStart} with sum: {lssSum}.");
            Console.WriteLine(string.Join(" ", lss));
        }
    }
}
