using System;

namespace P09WeatherForecast
{
    class P09WeatherForecast
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            if(weather.Equals("sunny"))
            {
                Console.WriteLine("It's warm outside!");
            } else
            {
                Console.WriteLine("It's cold outside!");
            }
            
        }
    }
}
