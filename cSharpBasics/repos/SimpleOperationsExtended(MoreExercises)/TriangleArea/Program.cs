using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double triangelArea = a * h / 2;

            Console.WriteLine($"{triangelArea:F2}");
        }
    }
}
