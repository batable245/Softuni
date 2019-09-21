using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string enteringUnit = Console.ReadLine();
            string endingUnit = Console.ReadLine();

            if (enteringUnit == "mm")
            {
                number /= 1000;
                //number = m; pravim go za da vurnem i metrite.
            }
            else if (enteringUnit == "cm")
            {
                number /= 100; 
            }
            if (endingUnit == "mm")
            {
                number *= 1000;
            }
            else if (endingUnit == "cm")
            {
                number *= 100;
            }
            Console.WriteLine($"{number:F3}", number);
        }
    }
}
