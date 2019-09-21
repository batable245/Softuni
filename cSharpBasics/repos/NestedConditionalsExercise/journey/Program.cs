using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string placeToStay = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season.Equals("summer"))
                {
                    placeToStay = "Camp";
                    price = 0.30 * budget;
                }
                else if (season.Equals("winter"))
                {
                    placeToStay = "Hotel";
                        price = 0.70 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season.Equals("summer"))
                {
                    placeToStay = "Camp";
                    price = 0.40 * budget;
                }
                else if (season.Equals("winter"))
                {
                    placeToStay = "Hotel";
                    price = 0.80 * budget;
                }
            }
            else
            {
                destination = "Europe";
                placeToStay = "Hotel";
                price = 0.90 * budget;
            }

            Console.WriteLine($"Somewhere in {destination} \r\n" + ($"{placeToStay} - {price:F2}"));
        }
    }
}
