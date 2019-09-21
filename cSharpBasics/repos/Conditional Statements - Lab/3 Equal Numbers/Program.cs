using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberToText = "";

            switch (number)
            {
                case 1: numberToText = "one";
                    break;
                case 2:
                    numberToText = "two";
                    break;
                case 3:
                    numberToText = "three";
                    break;
                case 4:
                    numberToText = "four";
                    break;
                case 5:
                    numberToText = "five";
                    break;
                case 6:
                    numberToText = "six";
                    break;
                case 7:
                    numberToText = "seven";
                    break;
                case 8:
                    numberToText = "eight";
                    break;
                case 9:
                    numberToText = "nine";
                    break;
                default:
                    numberToText = "number too big";
                    break;
            }
            Console.WriteLine(numberToText);
        }
    }
}
