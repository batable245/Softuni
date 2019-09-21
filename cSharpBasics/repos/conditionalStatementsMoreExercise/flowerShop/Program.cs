using System;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double sumFlowers = magnolia * 3.25 + hyacinth * 4 + rose * 3.5 + cactus * 8;
            double tax = sumFlowers * 0.05;
            double profit = sumFlowers - tax;

            if (profit >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - profit)} leva.");
            }
        }
    }
}
