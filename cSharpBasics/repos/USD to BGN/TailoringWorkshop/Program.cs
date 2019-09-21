using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangleTables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double cover = rectangleTables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double square = rectangleTables * (length / 2) * (length / 2);

            double coverMoney = 7 * cover;
            double squareMoney = 9 * square;

            double dollars = coverMoney + squareMoney;

            double leva = dollars * 1.85;

            Console.WriteLine($"{dollars:F2} USD");
            Console.WriteLine($"{leva:F2} BGN");
        }
    }
}
