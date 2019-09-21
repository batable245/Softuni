using System;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapesForSquareMetre = double.Parse(Console.ReadLine());
            int litersWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wholeGrapes = vineyard * grapesForSquareMetre;
            double wine = (0.40 * wholeGrapes) / 2.5;

            if (wine >= litersWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.\r\n{Math.Ceiling(wine - litersWine)} liters left -> {Math.Ceiling((wine - litersWine) / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersWine - wine)} liters wine needed.");
            }
        }
    }
}
