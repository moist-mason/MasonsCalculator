// Mason's Calculator v0.1.0
// Written in Visual Studio 2019 using .NET Core 
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

            Console.Write("Finally, enter an operator (+ - / *): ");
            string userOp = Console.ReadLine();

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
                default:
                    Console.WriteLine("Invalid operator was entered. Equation not calculated.");
                    break;
            }
        }
    }
}
