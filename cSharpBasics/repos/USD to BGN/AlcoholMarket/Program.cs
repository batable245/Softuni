using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerAmount = double.Parse(Console.ReadLine());
            double wineAmount = double.Parse(Console.ReadLine());
            double brandyAmount = double.Parse(Console.ReadLine());
            double whiskyAmount = double.Parse(Console.ReadLine());

            double brandyPrice = (0.5 * whiskyPrice);
            double winePrice = brandyPrice - (0.4 * brandyPrice);
            double beerPrice = brandyPrice - (0.8 * brandyPrice);

            double brandySum = brandyPrice * brandyAmount;
            double whiskySum = whiskyPrice * whiskyAmount;
            double wineSum =   winePrice   *  wineAmount;
            double beerSum = beerPrice * beerAmount;

            double sumEveryting = brandySum + whiskySum + wineSum + beerSum;

            Console.WriteLine($"{sumEveryting:F2}");
        }
    }
}
