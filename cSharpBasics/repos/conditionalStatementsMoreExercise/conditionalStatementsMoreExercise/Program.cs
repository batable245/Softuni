using System;

namespace conditionalStatementsMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hoursOfAbsence = double.Parse(Console.ReadLine());

            double litersWater = (pipe1 * hoursOfAbsence) + (pipe2 * hoursOfAbsence);
            double pipe1Work = ((pipe1 * hoursOfAbsence) / litersWater) * 100;
            double pipe2Work = ((pipe2 * hoursOfAbsence) / litersWater) * 100;

            if (litersWater <= volume)
            {
                Console.WriteLine($"The pool is {(litersWater / volume) * 100}% full. Pipe 1: {pipe1Work: F2}%. Pipe 2: {pipe2Work:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursOfAbsence} hours the pool overflows with {litersWater - volume:F2} liters.");
            }
        }
    }
}
