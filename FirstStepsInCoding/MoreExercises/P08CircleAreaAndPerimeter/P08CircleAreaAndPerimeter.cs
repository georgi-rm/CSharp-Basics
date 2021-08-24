using System;

namespace P08CircleAreaAndPerimeter
{
    class P08CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * r * Math.PI;
            double area = r * r * Math.PI;
            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
