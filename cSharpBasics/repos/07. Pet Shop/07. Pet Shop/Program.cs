using System;

namespace _07._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());

            int otherAnimals = int.Parse(Console.ReadLine());

            double dogFood = dogsCount * 2.5;

            double otherAnimalsFood = otherAnimals * 4;

            double sum = dogFood + otherAnimalsFood;

            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
