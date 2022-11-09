using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < lines; i++)
            {
                char alphabet = char.Parse(Console.ReadLine());

                sumOfChars += (int)alphabet;

            }
            Console.WriteLine($"The sum equals: {sumOfChars}"); 
        }
    }
}
