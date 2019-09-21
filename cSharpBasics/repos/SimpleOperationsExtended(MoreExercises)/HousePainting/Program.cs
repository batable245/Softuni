using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double sideWallLength = double.Parse(Console.ReadLine());
            double triangelRoofWallHeight = double.Parse(Console.ReadLine());

            double sideWallArea = sideWallLength * houseHeight;
            double windowArea = 1.5 * 1.5;
            double twoWallSides = 2 * sideWallArea - 2 * windowArea;
            double backWall = houseHeight * houseHeight;
            double entrance = 1.2;
            double frontAndBackWall = 2 * backWall - 2 * entrance;
            double wholeAreaWalls = twoWallSides + frontAndBackWall;

            double greenPaint = wholeAreaWalls / 3.4;

            double rectanglesOnRoof = 2 * (houseHeight* sideWallLength);
            double twoTriangels = 2 * (houseHeight * triangelRoofWallHeight / 2);
            double wholeAreaRoof = rectanglesOnRoof + twoTriangels;

            double redPaint = wholeAreaRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
