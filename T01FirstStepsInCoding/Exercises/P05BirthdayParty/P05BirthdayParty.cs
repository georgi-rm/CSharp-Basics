using System;

namespace P05BirthdayParty
{
    class P05BirthdayParty
    {
        static void Main(string[] args)
        {
            double rentForTheHall = double.Parse(Console.ReadLine());
            double priceOfTheCake = rentForTheHall * 0.2;
            double priceOfDrinks = priceOfTheCake * 0.55;
            double priceForAnimator = rentForTheHall / 3;
            double total = rentForTheHall + priceOfTheCake + priceOfDrinks + priceForAnimator;
            Console.WriteLine(total);
        }
    }
}
