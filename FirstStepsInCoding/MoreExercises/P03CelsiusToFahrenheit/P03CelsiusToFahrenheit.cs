﻿using System;

namespace P03CelsiusToFahrenheit
{
    class P03CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{fahrenheit:F2}");
        }
    }
}
