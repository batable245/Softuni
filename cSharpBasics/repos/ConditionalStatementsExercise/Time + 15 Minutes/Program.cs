using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());

            int totalTime = startHour * 60 + startMinutes + 15;

            int finalHour = totalTime / 60;
            int finalMinutes = totalTime % 60;

            if (finalHour == 24)
            {
                finalHour = 0;
            }
            if (finalMinutes <= 9)
            {
                Console.WriteLine(finalHour + ":0" + finalMinutes);
            }
            else
            {
                Console.WriteLine(finalHour + ":" + finalMinutes);
            }
        }
    }
}
