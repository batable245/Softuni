using System;

namespace _08._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double priceForGreening = area * 7.61;

            double discount = 0.18 * priceForGreening;

            double finalPrice = priceForGreening - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
