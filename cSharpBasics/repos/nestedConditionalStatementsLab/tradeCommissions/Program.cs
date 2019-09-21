using System;

namespace tradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commission = 0;

            if (city == "Sofia")
            {
                if (0 <= sells && sells <= 500)
                {
                    commission = sells * 0.05;
                }
                else if (500 < sells && sells <= 1000)
                {
                    commission = sells * 0.07;
                }
                else if (1000 < sells && sells <= 10000)
                {
                    commission = sells * 0.08;
                }
                else if (sells > 10000)
                {
                    commission = sells * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= sells && sells <= 500)
                {
                    commission = sells * 0.045;
                }
                else if (500 < sells && sells <= 1000)
                {
                    commission = sells * 0.075;
                }
                else if (1000 < sells && sells <= 10000)
                {
                    commission = sells * 0.10;
                }
                else if (sells > 10000)
                {
                    commission = sells * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sells && sells <= 500)
                {
                    commission = sells * 0.055;
                }
                else if (500 < sells && sells <= 1000)
                {
                    commission = sells * 0.08;
                }
                else if (1000 < sells && sells <= 10000)
                {
                    commission = sells * 0.12;
                }
                else if (sells > 10000)
                {
                    commission = sells * 0.145;
                }
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
