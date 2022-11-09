using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            long sumSpices = 0;
            uint day = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(sumSpices);
                Console.WriteLine(day);
                return;
            }
            else
            {
                while (startingYield >= 100)
                {
                    sumSpices += ((long)startingYield - 26);
                    startingYield -= 10;
                    day++;
                }
                Console.WriteLine(day);
                Console.WriteLine(sumSpices - 26);
            }
        }
    }
}
