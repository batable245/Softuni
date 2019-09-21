using System;

namespace fuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double gasPrice = 0.93;
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;

            if (card.Equals("Yes"))
            {
                gasPrice -= 0.08;
                gasolinePrice -= 0.18;
                dieselPrice -= 0.12;
            }

            double price = 0.0;

            if (fuelType.Equals("Gas"))
            {
                price = litersFuel * gasPrice;
            }
            else if ((fuelType.Equals("Gasoline")))
            {
                price = litersFuel * gasolinePrice;
            }
            else if ((fuelType.Equals("Diesel")))
            {
                price = litersFuel * dieselPrice;
            }

            if (litersFuel >= 20 && litersFuel <= 25)
            {
                double discount = price * 0.08;
                price = price - discount;
            }
            else if (litersFuel > 25)
            {
                double discount = price * 0.10;
                price = price - discount;
            }
            
            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
