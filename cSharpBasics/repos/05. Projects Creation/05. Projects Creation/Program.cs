using System;

namespace _05._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int hours = projectsCount * 3;
            Console.WriteLine($"The architect {firstname} will need {hours} hours to complete {projectsCount}");
        }
    }
}
