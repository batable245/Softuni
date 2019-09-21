using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForOneFlower = 0;

            if (typeFlowers.Equals("Roses"))
            {
                priceForOneFlower = 5;
            }
            else if (typeFlowers.Equals("Dahlias"))
            {
                priceForOneFlower = 3.80;
            }
            else if (typeFlowers.Equals("Tulips"))
            {
                priceForOneFlower = 2.80;
            }
            else if (typeFlowers.Equals("Narcissus"))
            {
                priceForOneFlower = 3;
            }
            else if (typeFlowers.Equals("Gladiolus"))
            {
                priceForOneFlower = 2.50;
            }

            double totalPrice = flowersCount  * priceForOneFlower;

            if (flowersCount > 80 && typeFlowers == "Roses")
            {
                totalPrice = totalPrice * 0.90;
            }
            else if (flowersCount > 90 && typeFlowers == "Dahlias")
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (flowersCount > 80 && typeFlowers == "Tulips")
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (flowersCount < 120 && typeFlowers == "Narcissus")
            {
                totalPrice = totalPrice * 1.15;
            }
            else if (flowersCount < 80 && typeFlowers == "Gladiolus")
            {
                totalPrice = totalPrice * 1.20;
            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeFlowers} and {leftMoney:F2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
            }
        }
    }
}
