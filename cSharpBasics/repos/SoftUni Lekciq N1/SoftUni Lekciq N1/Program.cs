using System;

namespace SoftUni_Lekciq_N1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Ani";

            name = name.ToLower();

            bool Contains = name.Contains("a");

            Console.WriteLine(Contains);
        }
    }
}
