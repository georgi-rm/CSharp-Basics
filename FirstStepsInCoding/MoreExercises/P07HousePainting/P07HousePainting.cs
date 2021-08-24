using System;

namespace P07HousePainting
{
    class P07HousePainting
    {
        static void Main(string[] args)
        {
            double heightOfHouse = double.Parse(Console.ReadLine());
            double widthOfHouse = double.Parse(Console.ReadLine());
            double heightOfRoof = double.Parse(Console.ReadLine());

            double areaOfFrontAndBackWalls = 2 * heightOfHouse * heightOfHouse;
            areaOfFrontAndBackWalls -= 1.2 * 2;

            double areaOfSideWalls = 2 * heightOfHouse * widthOfHouse - 2 * 1.5 * 1.5;

            double areaOfHouse = areaOfFrontAndBackWalls + areaOfSideWalls;
            double areaOfRoof = heightOfHouse * widthOfHouse * 2 + 2 * heightOfHouse * heightOfRoof / 2;

            double litersOfGreenPaint = areaOfHouse / 3.4;
            double litersOfRedPaint = areaOfRoof / 4.3;
            Console.WriteLine($"{litersOfGreenPaint:F2}");
            Console.WriteLine($"{litersOfRedPaint:F2}");
        }
    }
}
