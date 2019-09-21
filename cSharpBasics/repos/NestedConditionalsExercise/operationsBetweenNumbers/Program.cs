using System;

namespace operationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            if (operation == '+')
            {
                int sum = number1 + number2;

                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {sum} - even ");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {sum} - odd ");
                }
            }
            else if (operation == '-')
            {
                int diff = number1 - number2;

                if (diff % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {diff} - even ");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {diff} - odd ");
                }
            }
            else if (operation == '*')
            {
                int product = number1 * number2;

                if (product % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {product} - even ");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {product} - odd ");
                }
            }
            else if (operation == '/')
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    double division = number1 * 1.00 / number2;
                    Console.WriteLine($"{number1} / {number2} = {division:F2}");
                }
            }
            else if (operation == '%')
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    int leftover = number1 % number2;
                    Console.WriteLine($"{number1} % {number2} = {leftover}");
                }
            }
        }
    }
}
