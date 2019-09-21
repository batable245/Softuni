using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceMetres = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double needsToSwim = distanceMetres * timeInSeconds;
            distanceMetres = (Math.Floor(distanceMetres / 15)) * 12.5;
            double wholeTime = (needsToSwim + distanceMetres);

            //  if (worldRecord <= wholeTime)
            // {
            //     Console.WriteLine($"No, he failed! He was " +
            //      $"{wholeTime - worldRecord:F2} seconds slower.");
            // }
            // else
            //   {
            //     Console.WriteLine($"Yes, he succeeded! The " +
            //          $"new world record is " +
            //         $"{wholeTime:F2} seconds.");
            // }
            if (wholeTime >= worldRecord)
            {
                Console.WriteLine($"No, he failed! He was " +
                 $"{wholeTime - worldRecord:F2} seconds slower.");
            }
            else
              {
                Console.WriteLine($"Yes, he succeeded! The " +
                     $"new world record is " +
                    $"{wholeTime:F2} seconds.");
            }
        }
    }
}
