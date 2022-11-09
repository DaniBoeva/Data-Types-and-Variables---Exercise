using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxSnowballValue = BigInteger.MinusOne;
            int maxSnowballSnow = int.MinValue;
            int maxSnowballTime = int.MinValue;
            int maxSnowballQuality = int.MinValue;

            for (int i = 1; i <= numOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballsValue = BigInteger.Pow((snowballSnow / snowballTime), (snowballQuality));

                if (snowballsValue > maxSnowballValue)
                {
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballValue = snowballsValue;
                }

            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
        }
    }
}
