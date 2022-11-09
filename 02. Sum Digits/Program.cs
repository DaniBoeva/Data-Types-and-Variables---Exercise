using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            int currentNum = inputNum;

            for (int i = 0; i < inputNum; i++)
            {
               
                while (currentNum>0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }
            }
            Console.WriteLine($"{sumOfDigits}");
        }
    }
}
