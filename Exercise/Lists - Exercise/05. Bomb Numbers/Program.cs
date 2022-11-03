using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bombingPlace = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            for (int i = 0; i < bombingPlace.Count; i++)
            {
                if (bomb == bombingPlace[i])
                {
                    BombPower(bomb, power, bombingPlace, i);
                }
            }
            Console.WriteLine(bombingPlace.Sum());
        }

        static void BombPower(int bomb, int power, List<int> bombingPlace, int index)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(bombingPlace.Count - 1, index + power);
            for (int i = start; i <= end; i++)
            {
                bombingPlace[i] = 0;
            }
        }
    }
}
