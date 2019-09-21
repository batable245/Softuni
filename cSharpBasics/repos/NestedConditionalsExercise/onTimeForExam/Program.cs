using System;

namespace onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arriveTime = arrivalHour * 60 + arrivalMinutes;

            int hours = (arriveTime - examTime) / 60;
            int minutes = (arriveTime - examTime) % 60;

            if (arriveTime > examTime)
            {
                Console.WriteLine("Late");
                if (hours > 0)
                {
                    Console.WriteLine($"{hours + ":" + minutes.ToString("D2")} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
            else if (arriveTime == examTime || examTime - arriveTime <= 30)
            {
                Console.WriteLine("On time");

                int onTime = examTime - arriveTime;

                if (onTime <= 30 && onTime != 0)
                {
                    Console.WriteLine($"{onTime} minutes before the start");
                }
            }
            else if (examTime - arriveTime > 30)
            {
                Console.WriteLine("Early");
                if (examTime - arriveTime < 60)
                {
                    Console.WriteLine($"{examTime - arriveTime} minutes before the start");
                }
                else
                {
                    int hour = (examTime - arriveTime) / 60;
                    int minute = (examTime - arriveTime) % 60;

                    Console.WriteLine($"{hour + ":" + minute.ToString("D2")} hours before the start");
                }
            }
        }
    }
}
