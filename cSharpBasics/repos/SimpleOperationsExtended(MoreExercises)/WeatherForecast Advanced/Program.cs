using System;

namespace WeatherForecast_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreese = double.Parse(Console.ReadLine());

            if (degreese >= 26.00 && degreese <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degreese >= 20.01 && degreese <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degreese >= 15.00 && degreese <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degreese >= 12.00 && degreese <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degreese >= 5.00 && degreese <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
