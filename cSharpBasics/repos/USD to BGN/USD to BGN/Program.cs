﻿using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            //Console.WriteLine(Math.Round(bgn, 2));
            Console.WriteLine($"{bgn:F2}");
        }
    }
}
