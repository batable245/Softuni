using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string dwelling = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0.0;
            double nights = days - 1;

            if (dwelling == "room for one person")
            {
                price = nights * 18.00;
            }
            else if (dwelling == "apartment")
            {
                price = nights * 25.00;

                if (days < 10)
                {
                    price = (nights * 25.00) * 0.70;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (nights * 25.00) * 0.65;
                }
                else if (days > 15)
                {
                    price = (nights * 25.00) * 0.50;
                }
            }
            else if (dwelling == "president apartment")
            {
                price = nights * 35.00;

                if (days < 10)
                {
                    price = (nights * 35.00) * 0.90;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (nights * 35.00) * 0.85;
                }
                else if (days > 15)
                {
                    price = (nights * 35.00) * 0.80;
                }
            }
            if (rating.Equals("positive"))
            {
                price = price + price * 0.25;
            }
            else if (rating.Equals("negative"))
            {
                price = price - price * 0.10;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
