using System;

namespace P05TrainingLab
{
    class P05TrainingLab
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()) * 100;
            double weigth = double.Parse(Console.ReadLine()) * 100;

            double weigthForWorkStations = weigth - 100;
            int workStationsOnWeigth = (int)(weigthForWorkStations / 70);
            int workstationsOnLength = (int)(length / 120);

            int totalWorkStations = workStationsOnWeigth * workstationsOnLength - 3;
            Console.WriteLine(totalWorkStations);
        }
    }
}
