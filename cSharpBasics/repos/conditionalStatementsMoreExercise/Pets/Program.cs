using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double dogFoodNeeded = days * dogFood;
            double catFoodNeeded = days * catFood;
            double turtleFoodNeeded = days * (turtleFood / 1000);

            double allFood = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

            if (allFood <= food)
            {
                Console.WriteLine($"{Math.Floor(food - allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood - food)} more kilos of food are needed.");
            }
        }
    }
}
