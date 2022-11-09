using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double course = capacity / people;

            Console.WriteLine($"{Math.Ceiling(course)}");
        }
    }
}
