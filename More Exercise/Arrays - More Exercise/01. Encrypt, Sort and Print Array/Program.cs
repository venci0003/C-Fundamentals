using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            string[] textArray = new string[arraySize];
            int[] numArray = new int[arraySize];

            // Reading words and converting them into integer values
            for (int wordIndex = 0; wordIndex < textArray.Length; wordIndex++)
            {
                textArray[wordIndex] = Console.ReadLine();
                for (int letterIndex = 0; letterIndex < textArray[wordIndex].Length; letterIndex++)
                {
                    int symbol = (int)textArray[wordIndex][letterIndex];

                    switch (symbol)
                    {
                        case 65:
                        case 69:
                        case 73:
                        case 79:
                        case 85:
                        case 97:
                        case 101:
                        case 105:
                        case 111:
                        case 117: // vowel
                            numArray[wordIndex] += symbol * textArray[wordIndex].Length;
                            break;
                        default: // consonant
                            numArray[wordIndex] += symbol / textArray[wordIndex].Length;
                            break;
                    }
                }
            }

            // Sorting the numbers in the numeric array
            for (int numIndex = 0; numIndex < arraySize - 1; numIndex++)
            {
                for (int i = numIndex + 1; i < arraySize; i++)
                {
                    if (numArray[numIndex] > numArray[i]) // Swapping the numbers when needed
                    {
                        int temporary = numArray[numIndex];
                        numArray[numIndex] = numArray[i];
                        numArray[i] = temporary;
                    }
                }
            }

            // Output
            for (int i = 0; i < arraySize; i++) Console.WriteLine(numArray[i] + " ");
        }
    }
}
