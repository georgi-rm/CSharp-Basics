using System;

namespace P01ExcellentResult
{
    class P01ExcellentResult
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if(grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
