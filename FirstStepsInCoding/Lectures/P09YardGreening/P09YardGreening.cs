using System;

namespace P09YardGreening
{
    class P09YardGreening
    {
        static void Main(string[] args)
        {
            double areaForGreening = double.Parse(Console.ReadLine());
            double normalPrice = areaForGreening * 7.61;
            double discount = normalPrice * 0.18;
            double finalPrice = normalPrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
