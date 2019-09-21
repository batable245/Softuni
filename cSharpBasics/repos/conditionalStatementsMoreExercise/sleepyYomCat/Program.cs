using System;

namespace sleepyYomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int playTimeDuringHolidays = holidays * 127;
            int playTimeDuringWorkDays = (365 - holidays) * 63;
            int playTime = playTimeDuringHolidays + playTimeDuringWorkDays;
            int playTimeLeft = 30000 - playTime;
            int playTimeOver = playTime - 30000;

            if (30000 > playTime)
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{playTimeLeft / 60} hours and {playTimeLeft % 60} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away\r\n{playTimeOver / 60} hours and {playTimeOver % 60} minutes more for play");
            }

            //Console.WriteLine($"Tom will run away\r\n"); very important! you won't need a second Console.WriteLine();
        }
    }
}
