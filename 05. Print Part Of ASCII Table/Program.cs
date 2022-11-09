using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCh = int.Parse(Console.ReadLine());
            int endCh = int.Parse(Console.ReadLine());


            for (int i = startCh; i <= endCh; i++)
            {
                char currentCh = (char)i;
                Console.Write(currentCh + " ");
            }
        }
    }
}
