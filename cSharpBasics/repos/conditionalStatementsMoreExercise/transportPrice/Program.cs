using System;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometres = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            if (kilometres >= 100)
            {
                Console.WriteLine($"{kilometres * 0.06:F2}");
            }
            else if (kilometres >= 20)
            {
                Console.WriteLine($"{kilometres * 0.09:F2}");
            }
            else
            {
                if (partOfDay.Equals("day"))
                {
                    Console.WriteLine($"{0.70 + kilometres * 0.79:F2}");
                }
                else if (partOfDay.Equals("night"))
                {
                    Console.WriteLine($"{0.70 + kilometres * 0.90:F2}");
                }
            }
        }
    }
}
