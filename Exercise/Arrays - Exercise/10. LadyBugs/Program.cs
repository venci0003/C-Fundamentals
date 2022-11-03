using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] lBugInitialPositionIndex = Console.ReadLine()      // get initial Bug positions
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ladyBugField = new int[fieldSize];

            for (int i = 0; i < ladyBugField.Length; i++)   //setting '1' on initial bug positions
            {
                if (lBugInitialPositionIndex.Contains(i))
                {
                    ladyBugField[i] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] rules = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialPosition = int.Parse(rules[0]);
                string direction = rules[1];
                int countOfMoves = int.Parse(rules[2]);

                int newPosition = 0;

                if (countOfMoves < 0)
                {
                    if (direction == "left")
                    {
                        direction = "right";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                    else if (direction == "right")
                    {
                        direction = "left";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                }

                if (initialPosition < 0     //check if initial position is out of array or if initial position has NO bug
                   || initialPosition > ladyBugField.Length - 1
                   || ladyBugField[initialPosition] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (countOfMoves == 0 && initialPosition >= 0 && initialPosition <= ladyBugField.Length - 1)
                {
                    if (ladyBugField[initialPosition] == 1)
                    {
                        ladyBugField[initialPosition] = 0;
                    }

                }

                switch (direction)
                {

                    case "right":

                        newPosition = initialPosition + countOfMoves; //find new position index

                        ladyBugField[initialPosition] = 0; //both cases initial index gets '0'

                        if (newPosition > ladyBugField.Length - 1) //check if new position index is out of array
                        {
                            ladyBugField[initialPosition] = 0;  //if it is out , cuurent position get '0'-LB flies out of the array
                            break;
                        }
                        else
                        {
                            for (int i = newPosition; i < ladyBugField.Length; i += countOfMoves) // array goes till LB find free index, or goes out of tje field
                            {
                                if (ladyBugField[i] == 0) //if new position has no LB, current LB land here
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }

                        }
                        break;

                    case "left":

                        newPosition = initialPosition - countOfMoves;


                        ladyBugField[initialPosition] = 0; //in both cases initial position gets '0'
                        if (newPosition < 0) //if new posiion is out of array initial index of LB gets '0'
                        {
                            ladyBugField[initialPosition] = 0;
                            break;
                        }

                        else
                        {
                            for (int i = newPosition; i >= 0; i -= countOfMoves) //find free index or LB gets out of the array
                            {
                                if (ladyBugField[i] == 0)  //if index is free LB lands here
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }

                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
