using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte beerKegs = byte.Parse(Console.ReadLine());

            string maxModel = string.Empty;
            double maxVolume = 0;

            for (int i = 0; i < beerKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                
                double volume = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;
                double currentVolume = volume;

                if (volume >= maxVolume)
                {
                    maxVolume = currentVolume;
                    maxModel = modelOfKeg;

                }
            }

            Console.WriteLine($"{maxModel}");
            


        }
    }
}
