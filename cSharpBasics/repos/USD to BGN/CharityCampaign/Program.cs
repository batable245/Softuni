using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysDuringCampaign = int.Parse(Console.ReadLine());
            int candyMakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            double waffles = int.Parse(Console.ReadLine());
            double pancakes = int.Parse(Console.ReadLine());

            int cakesForOneDayFromOneBaker = cakes * 45;
            double wafflesForOneDayFromOneBaker = waffles * 5.80;
            double pancakesForOneDayFromOneBaker = pancakes * 3.20;

            double moneyForOneDay = (cakesForOneDayFromOneBaker + wafflesForOneDayFromOneBaker + pancakesForOneDayFromOneBaker) * candyMakers;
            double moneyForWholeCampaign = moneyForOneDay * daysDuringCampaign;
            double priceAfterCosts = moneyForWholeCampaign - ((1D / 8) * moneyForWholeCampaign);

            Console.WriteLine($"{priceAfterCosts:F2}");
        }
    }
}
