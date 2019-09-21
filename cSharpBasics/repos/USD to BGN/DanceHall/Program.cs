using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine()) * 100;
            double hallWidth = double.Parse(Console.ReadLine()) * 100;
            double squareWardrobeLength = double.Parse(Console.ReadLine()) * 100;

            double hallArea = (hallLength * hallWidth);
            double wardrobeArea = squareWardrobeLength * squareWardrobeLength;
            double benchArea = hallArea / 10;
            double freeSpace = hallArea - wardrobeArea - benchArea;
            double dancersCount = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancersCount));
        }
    }
}
