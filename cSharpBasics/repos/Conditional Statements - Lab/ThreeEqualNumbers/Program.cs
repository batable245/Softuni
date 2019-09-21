using System;

namespace ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string dayToText = "";

            switch (number)
            {
                case 1:
                    dayToText = "Monday";
                    break;
                case 2:
                    dayToText = "Tuesday";
                    break;
                case 3:
                    dayToText = "Wednesday";
                    break;
                case 4:
                    dayToText = "Thursday";
                    break;
                case 5:
                    dayToText = "Friday";
                    break;
                case 6:
                    dayToText = "Saturday";
                    break;
                case 7:
                    dayToText = "Sunday";
                    break;
                default:
                    dayToText = "Error";
                    break;
            }
            Console.WriteLine(dayToText);
        }
    }
}
