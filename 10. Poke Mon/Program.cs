using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int sumTargets = 0;
            int pokePowerN = pokePower;

            if (pokePower < distanceM)
            {
                Console.WriteLine(pokePowerN);
                Console.WriteLine(sumTargets);
            }

            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                sumTargets++;

                if ((pokePowerN == pokePower * 0.5) && (exhaustionFactorY > 0))
                {
                    pokePowerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(sumTargets);
        }
    }
}
