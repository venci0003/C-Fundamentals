using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            int originalPokePower = pokePower;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokeCounter++;
                decimal halfFromPowerValue = originalPokePower / 2;
                if (pokePower < distance)
                {
                    break;
                }
                if (pokePower == halfFromPowerValue && exhaust > 0)
                {
                    pokePower = (int)pokePower / exhaust;
                }
            }
            Console.WriteLine($"{pokePower}\n{pokeCounter}");
        }
    }
}
