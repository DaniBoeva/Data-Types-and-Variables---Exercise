using System;
using System.Numerics;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int furstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdhNum = int.Parse(Console.ReadLine());
            int fourNum = int.Parse(Console.ReadLine());

            long sum = (long)furstNum + secondNum;
            long divide = sum / thirdhNum;
            BigInteger multiply = BigInteger.Multiply(divide, fourNum);

            Console.WriteLine($"{multiply}");

        }
    }
}
