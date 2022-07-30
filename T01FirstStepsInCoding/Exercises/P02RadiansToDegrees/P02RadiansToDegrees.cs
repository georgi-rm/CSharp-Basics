using System;

namespace P02RadiansToDegrees
{
    class P02RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degree = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree));
        }
    }
}
