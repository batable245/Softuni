using System;

namespace contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            bool isContains = name.Contains("A");
             
            Console.WriteLine(isContains);
        }
    }
}
