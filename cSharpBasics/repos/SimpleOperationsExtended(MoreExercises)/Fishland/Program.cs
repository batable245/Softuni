using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double palamudKilogram= double.Parse(Console.ReadLine());
            double horsemackerelKilogram = double.Parse(Console.ReadLine());
            double musselsKilogram = double.Parse(Console.ReadLine());

            double palamudPriceForOneKilo = mackerelPrice + mackerelPrice * 0.60;
            double palamudSum = palamudKilogram * palamudPriceForOneKilo;
            double horsemackerelPriceForOneKilo = spratPrice + 0.80 * spratPrice;
            double horsemackerelSum = horsemackerelKilogram * horsemackerelPriceForOneKilo;
            double musselsSum = musselsKilogram * 7.50;


            double sumEverything = palamudSum + horsemackerelSum + musselsSum;

            Console.WriteLine($"{sumEverything:F2}");
        }
    }
}
