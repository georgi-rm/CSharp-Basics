using System;

namespace P06Fishland
{
    class P06Fishland
    {
        static void Main(string[] args)
        {
            double priceOfSkumria = double.Parse(Console.ReadLine());
            double priceOfCaca = double.Parse(Console.ReadLine());
            double quantityOfPalamud = double.Parse(Console.ReadLine());
            double quantityOfSafrid = double.Parse(Console.ReadLine());
            int quantityOfSchels = int.Parse(Console.ReadLine());

            double priceOfPalamud = priceOfSkumria * 1.6;
            double priceOfSafrid = priceOfCaca * 1.8;

            double totalForPalamud = priceOfPalamud * quantityOfPalamud;
            double totalForSafrid = priceOfSafrid * quantityOfSafrid;
            double totalForSchels = quantityOfSchels * 7.5;

            double totalPriceOfFish = totalForPalamud + totalForSafrid + totalForSchels;
            Console.WriteLine($"{totalPriceOfFish:F2}");
        }
    }
}
