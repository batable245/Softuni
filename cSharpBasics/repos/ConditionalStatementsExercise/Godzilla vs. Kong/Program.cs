using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double priceForClothing = actors * clothes;

            if (actors > 150)
            {
                priceForClothing = priceForClothing - priceForClothing * 0.10;
            }

            double sum = decor + priceForClothing;
            double sumLeft = budget - sum;
            if (sum > budget)
            {
                sumLeft = sumLeft * -1;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {sumLeft:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {sumLeft:F2} leva left.");
            }
        }
    }
}
