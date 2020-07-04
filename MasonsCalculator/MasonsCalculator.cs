// Mason's Calculator v0.1.1
// Written in Visual Studio 2019 using .NET Core 3.1
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {
        static double num1;
        static double num2;

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Next, enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Operator();

            Console.ReadLine();
        }

        static void Operator()
        {
            double equation;

            Console.Write("Finally, enter an operator (+ - / * % ^): ");
            string userOp = Convert.ToString(Console.ReadLine());

            switch (userOp)
            {
                case "+":
                    equation = num1 + num2;
                    Console.WriteLine(equation);
                    break;
                case "-":
                    equation = num1 - num2;
                    Console.WriteLine(equation);
                    break;
                case "*":
                    equation = num1 - num2;
                    Console.WriteLine(equation);
                    break;
                case "/":
                    equation = num1 / num2;
                    Console.WriteLine(equation);
                    break;
                case "%":
                    equation = num1 % num2;
                    Console.WriteLine(equation);
                    break;
                case "^":
                    equation = Convert.ToInt32(num1) ^ Convert.ToInt32(num2);
                    Console.WriteLine(equation);
                    break;
                default:
                    Console.WriteLine("An invalid operator was entered. The equation won't be calculated. Press any key to terminate the console.");
                    break;
            }
        }
    }
}