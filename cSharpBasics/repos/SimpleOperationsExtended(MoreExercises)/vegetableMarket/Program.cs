using System;

namespace vegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKilos = double.Parse(Console.ReadLine());
            double fruitKilos = double.Parse(Console.ReadLine());

            double vegetableCost = vegetablePrice * vegetableKilos;
            double fruitCosts = fruitPrice * fruitKilos;
            double finalPrice = vegetableCost + fruitCosts;

            double convertedPrice = finalPrice / 1.94;

            Console.WriteLine($"{convertedPrice:F2}");

        }
    }
}
