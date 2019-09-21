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
                apartmentPrice = 50;
                studioPrice = 65;
                if (nights > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.70);
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.90);
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
                
            }
            if (month.Equals("June") || month.Equals("September"))
            {
                apartmentPrice = 75.20;
                studioPrice = 68.70;
                if (nights > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            if (month.Equals("July") || month.Equals("August"))
            {
                apartmentPrice = 76;
                studioPrice = 77;
                if (nights > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.); \r\n " + ($"Studio: {studioPrice:F2} lv."));
        }
    }
}
