using System;

namespace threeBros
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double dadAbsentTime = double.Parse(Console.ReadLine());

            double cleaningTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            double wholeTime = cleaningTime + 0.15 * cleaningTime;

            Console.WriteLine($"Cleaning time: {wholeTime:F2}");

            if (wholeTime <= dadAbsentTime)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(dadAbsentTime - wholeTime)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Abs(Math.Ceiling(wholeTime - dadAbsentTime))} hours.");
            }
        }
    }
}
