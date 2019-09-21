using System;

namespace choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //double totalStepsPerDayPercent = Math.Ceiling((steps * 1d / days) / steps) * 100d; it's 13 because we multiplay by 100
            //double stepsPerDancer = totalStepsPerDayPercent / dancers;
            double totalStepsPerDayPercent = Math.Ceiling((steps * 1.0 / days) / steps) * 100.0;
            double stepsPerDancer = totalStepsPerDayPercent / dancers;

            if (totalStepsPerDayPercent <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
