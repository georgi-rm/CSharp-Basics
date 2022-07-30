using System;

namespace P08PetShop
{
    class P08PetShop
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            double moneyForDogFood = numberOfDogs * 2.5;
            double moneyForOtherAnimalsFood = numberOfOtherAnimals * 4;
            double total = moneyForDogFood + moneyForOtherAnimalsFood;
            Console.WriteLine($"{total} lv.");
        }
    }
}
