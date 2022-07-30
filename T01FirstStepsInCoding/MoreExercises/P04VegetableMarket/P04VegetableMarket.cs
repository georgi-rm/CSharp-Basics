using System;

namespace P04VegetableMarket
{
    class P04VegetableMarket
    {
        static void Main(string[] args)
        {
            double priceOfVegetableInLv = double.Parse(Console.ReadLine());
            double priceOfFruitsInLv = double.Parse(Console.ReadLine());
            int quantityOfVegetables = int.Parse(Console.ReadLine());
            int quantityOfFruitsInLv = int.Parse(Console.ReadLine());

            double totalSumInLv = priceOfVegetableInLv * quantityOfVegetables + priceOfFruitsInLv * quantityOfFruitsInLv;
            double totalSumInEur = totalSumInLv / 1.94;
            Console.WriteLine($"{totalSumInEur:F2}");
        }
    }
}
