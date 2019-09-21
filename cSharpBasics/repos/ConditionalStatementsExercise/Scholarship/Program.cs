using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(0.35 * minSalary);
            double excellencyScholarship = Math.Floor(grade * 25);

            if (income > minSalary)
            {
                if (grade < 5.50)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellencyScholarship} BGN");
                }
            }
            else
            {
                if (grade >= 5.50)
                {
                    if (socialScholarship > excellencyScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }
                    else 
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {excellencyScholarship} BGN");
                    }
                }
                else if (grade >= 4.50)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
        }
    }
}
