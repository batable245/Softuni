using System;

namespace fuelTank1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double fuelInCar = double.Parse(Console.ReadLine());

            if (fuel.Equals("Diesel") || fuel.Equals("Gasoline") || fuel.Equals("Gas"))
            {
                if (fuelInCar < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
                else
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}

