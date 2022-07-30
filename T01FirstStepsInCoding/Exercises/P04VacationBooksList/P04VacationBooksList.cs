using System;

namespace P04VacationBooksList
{
    class P04VacationBooksList
    {
        static void Main(string[] args)
        {
            int numberOfPagesInCurrentBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDaysToReadTheBook = int.Parse(Console.ReadLine());

            double hoursNeededToReadTheBook = 1.0 * numberOfPagesInCurrentBook / pagesPerHour;
            double hoursToReadEachDay = 1.0 * hoursNeededToReadTheBook / numberOfDaysToReadTheBook;

            Console.WriteLine(hoursToReadEachDay);
        }
    }
}
