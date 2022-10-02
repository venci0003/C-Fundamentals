using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsMade = int.Parse(Console.ReadLine());
            BigInteger theBestSnowball = 0;
            string bestResult = string.Empty;

            for (int i = 0; i < snowballsMade; i++)
            {
                int snowForSnowball = int.Parse(Console.ReadLine());
                int timeToMakeASnowball = int.Parse(Console.ReadLine());
                int qualityOfSnowball = int.Parse(Console.ReadLine());
                BigInteger formula = BigInteger.Pow((snowForSnowball / timeToMakeASnowball), qualityOfSnowball);
                if (formula >= theBestSnowball)
                {
                    theBestSnowball = formula;
                    string result = ($"{snowForSnowball} : {timeToMakeASnowball} = {theBestSnowball} ({qualityOfSnowball})");
                    bestResult = result;
                }
            }
            Console.WriteLine(bestResult);
        }
    }
}
