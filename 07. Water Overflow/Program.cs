using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesN = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < linesN; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                sum += quantity;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantity;
                    continue;
                }
                
            }
            Console.WriteLine(sum);
            
        }
    }
}
