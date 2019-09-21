using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (type.Equals("Premiere"))
            {
                price = (rows * columns) * 12.00;
            }
            else if (type.Equals("Normal"))
            {
                price = (rows * columns) * 7.50;
            }
            else if (type.Equals("Discount"))
            {
                price = (rows * columns) * 5.00;
            }
            Console.WriteLine($"{price:F2} leva");
        }
    }
}
