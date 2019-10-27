using System;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string year = Console.ReadLine();
            int holidaysInYear = int.Parse(Console.ReadLine()); 
            int weekendsHome = int.Parse(Console.ReadLine());

            double gamesPlayedExtra = 0.0;

            int weekends = 48;
            double weekendsInSofia = weekends - weekendsHome;
            double gamesInSofia = weekendsInSofia * 0.75;
            double holidaysPlaying = holidaysInYear * 2.00 / 3;
            double gamesPlayed = gamesInSofia + weekendsHome + holidaysPlaying;

            //check logic again
            if (year.Equals("leap"))
            {
                gamesPlayedExtra = gamesPlayed * 0.15;
            }     

            double gamesPlayedInYear = gamesPlayed + gamesPlayedExtra;

            Console.WriteLine(Math.Floor(gamesPlayedInYear));
        }
    }
}
