using System;

namespace _09._Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double aquariumLength = double.Parse(Console.ReadLine());
            double aquariumWidth = double.Parse(Console.ReadLine());
            double aquariumHeight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumCapacity = aquariumLength * aquariumWidth * aquariumHeight;
            double totalLiters = aquariumCapacity * 0.001;
            double calculatedPercent = percent * 0.01;
            double litersNeeded = totalLiters * (1 - calculatedPercent);

            Console.WriteLine($"{litersNeeded:F3}");
        }
    }
}
