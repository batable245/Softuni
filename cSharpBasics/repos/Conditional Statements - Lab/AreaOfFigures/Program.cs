using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;
            switch (figureType)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        area = a * a;
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        area = a * b;
                        break;
                    }
                case "circle":
                    {
                        double radious = double.Parse(Console.ReadLine());
                        area = Math.PI * Math.Pow(radious, 2);
                        break;
                    }
                case "triangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        area = (a * height) / 2;
                        break;
                    }
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
