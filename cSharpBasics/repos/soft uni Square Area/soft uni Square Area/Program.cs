using System;

namespace soft_uni_Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            double area = Math.Pow(side, 2);
            //string area = Math.Pow(side, 2).ToString();


            Console.WriteLine(area);
        }
    }
}
