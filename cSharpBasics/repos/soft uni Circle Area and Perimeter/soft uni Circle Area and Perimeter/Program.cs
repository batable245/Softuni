using System;

namespace soft_uni_Circle_Area_and_Perimeter
{
    class Program
    {
        private const int V = 21;

        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(r,2);

            double perimeter = 2 * Math.PI * r;

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
