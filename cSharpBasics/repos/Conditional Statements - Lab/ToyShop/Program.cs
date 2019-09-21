using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double price = puzzles * 2.60 + speakingDolls * 3.00 + teddyBears * 4.10 + minions * 8.20 + trucks * 2.00;

            int numberOfDolls = puzzles + speakingDolls + teddyBears + minions + trucks;

            if (numberOfDolls >= 50)
            {
                price = price - (price * 0.25);
            }
            double rent = price * 0.10;
            double earnings = price - rent;
            if (earnings >= vacationPrice)
            {
                Console.WriteLine($"Yes! {earnings - vacationPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationPrice - earnings:F2} lv needed.");
            }
        }
    }
}