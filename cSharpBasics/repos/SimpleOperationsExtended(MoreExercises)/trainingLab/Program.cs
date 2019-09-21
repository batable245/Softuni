using System;

namespace trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine())* 100;
            double width = double.Parse(Console.ReadLine())* 100;

            double widthWithoutHallway = width - 100; 

            double desksPerRow = Math.Floor(widthWithoutHallway / 70);

            double allRows = Math.Floor(length / 120);

            double placesToSit = desksPerRow * allRows - 3;

            Console.WriteLine(placesToSit);
        }
    }
}
