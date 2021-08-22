using System;

namespace P08FishTank
{
    class P08FishTank
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int weigth = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percentageOfNonWatterFill = double.Parse(Console.ReadLine());

            double volumeInLiters = 1.0 * length * weigth * heigth / 1000;
            double volumeOfWatterInLiters = volumeInLiters * (1 - percentageOfNonWatterFill / 100);
            Console.WriteLine(volumeOfWatterInLiters);
        }
    }
}
