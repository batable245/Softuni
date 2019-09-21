using System;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month.Equals("May") || month.Equals("October"))
            {
                apartmentPrice = 65 * nights;
                studioPrice = 50 * nights;
                if (nights > 14)
                {
                    studioPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
                
            }
            if (month.Equals("June") || month.Equals("September"))
            {
                apartmentPrice = 68.70 * nights;
                studioPrice = 75.20 * nights;
                if (nights > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            if (month.Equals("July") || month.Equals("August"))
            {
                apartmentPrice = 77 * nights;
                studioPrice = 76 * nights;
                if (nights > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv. \r\n " + ($"Studio: {studioPrice:F2} lv."));
        }
    }
}
