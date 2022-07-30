using System;

namespace P03DepositCalculator
{
    class P03DepositCalculator
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int depositTimeInMonths = int.Parse(Console.ReadLine());
            double yearlyIncomePercent = double.Parse(Console.ReadLine());

            double finalSum = depositedSum + depositTimeInMonths * (depositedSum * yearlyIncomePercent / 100) / 12;
            Console.WriteLine(finalSum);
        }
    }
}
