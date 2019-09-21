using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            switch (animalType)
            {
                case "dog":
                    {
                        Console.WriteLine("mammal");
                        break;
                    }
                case "reptile":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "snake":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "crocodile":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                case "tortoise":
                    {
                        Console.WriteLine("reptile");
                        break;
                    }
                default:
                  Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
