using System;

namespace P07FruitMarket
{
    class P07FruitMarket
    {
        static void Main(string[] args)
        {
            double priceOfStrawberies = double.Parse(Console.ReadLine());
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberies = double.Parse(Console.ReadLine());
            double quantityOfStrawberies = double.Parse(Console.ReadLine());

            double priceOfRaspberies = priceOfStrawberies / 2;
            double priceOfOranges = priceOfRaspberies * 0.6;
            double priceOfBananas = priceOfRaspberies * 0.2;

            double totalForStrawberies = priceOfStrawberies * quantityOfStrawberies;
            double totalForRaspberies = priceOfRaspberies * quantityOfRaspberies;
            double totalForOranges = priceOfOranges * quantityOfOranges;
            double totalForBananas = priceOfBananas * quantityOfBananas;

            double moneyNeeded = totalForStrawberies + totalForRaspberies + totalForOranges + totalForBananas;
            Console.WriteLine(moneyNeeded);
        }
    }
}
