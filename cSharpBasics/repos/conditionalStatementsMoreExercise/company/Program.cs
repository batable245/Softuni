using System;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursForProject = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workersWorkingOffTime = int.Parse(Console.ReadLine());

            double workingTime = (0.90 * days) * 8;
            int workersOffTime = workersWorkingOffTime * (2 * days);
            double allHours = Math.Floor(workingTime + workersOffTime);

            if (allHours >= hoursForProject)
            {
                Console.WriteLine($"Yes!{allHours - hoursForProject} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursForProject - allHours} hours needed.");
            }
        }
    }
}
