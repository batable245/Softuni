using System;

namespace fromRadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {


            double radians = double.Parse(Console.ReadLine());

            double degreese = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(degreese));
        }
    }
}
