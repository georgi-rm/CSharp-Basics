using System;

namespace P06CharityCampaign
{
    class P06CharityCampaign
    {
        static void Main(string[] args)
        {
            int numberOfDaysForCampaign = int.Parse(Console.ReadLine());
            int numberOfSweetMakers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double priceOfCakesByOneSweetMaker = numberOfCakes * 45;
            double priceOfWafflesByOneSweetMaker = numberOfWaffles * 5.80;
            double priceOfPancakesByOneSweetMaker = numberOfPancakes * 3.20;

            double priceOfAllProductsByOneSweetMaker = priceOfCakesByOneSweetMaker + priceOfWafflesByOneSweetMaker + priceOfPancakesByOneSweetMaker;
            double priceOfAllProductsInTheCampaign = priceOfAllProductsByOneSweetMaker * numberOfSweetMakers * numberOfDaysForCampaign;

            double totalIncome = priceOfAllProductsInTheCampaign * 7 / 8;
            Console.WriteLine(totalIncome);
        }
    }
}
