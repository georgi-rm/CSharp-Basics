using System;

namespace P07ProjectsCreation
{
    class P07ProjectsCreation
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hoursNeededForAllProjects = numberOfProjects * 3;
            Console.WriteLine($"The architect {architectName} will need {hoursNeededForAllProjects} hours to complete {numberOfProjects} project/s.");
        }
    }
}
