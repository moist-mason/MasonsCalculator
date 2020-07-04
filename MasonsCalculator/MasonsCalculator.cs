// Mason's Calculator v0.2.3
// Written in Visual Studio 2019 using .NET Core 3.1
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {
        static double arithNum1;
        static double arithNum2;
        static double trigNum;
        static double absNum;

        static void Main(string[] args)
        {
            string mathType;

            Console.WriteLine("Welcome to Mason's Calculator v0.2.0. Which of the following functions do you want to perform? Please type in all uppercase.\nARITHMETIC, TRIGONOMETRY, ABSOLUTE VALUES");
            mathType = Console.ReadLine();

            switch (mathType)
            {
                case "ARITHMETIC":
                    CalculatorArithmetic();
                    break;
                case "TRIGONOMETRY":
                    CalculatorTrigonometry();
                    break;
                case "ABSOLUTE VALUES":
                    CalculatorAbsolute();
                    break;
                default:
                    Console.WriteLine("An invalid function was entered. Please select from the types given and make sure spelling and casing are accurate. Press any key to terminate the console.");
                    break;
            }
        }

        static void CalculatorArithmetic()
        {
            string userOp;

            Console.WriteLine("First, enter a number.");
            arithNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Next, enter another number.");
            arithNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Finally, enter one of the following operators:\n+, -, *, /, %, ^");
            userOp = Convert.ToString(Console.ReadLine());

            switch (userOp)
            {
                case "+":
                    Console.WriteLine(arithNum1 + arithNum2);
                    break;
                case "-":;
                    Console.WriteLine(arithNum1 - arithNum2);
                    break;
                case "*":
                    Console.WriteLine(arithNum1 * arithNum2);
                    break;
                case "/":
                    Console.WriteLine(arithNum1 / arithNum2);
                    break;
                case "%":
                    Console.WriteLine(arithNum1 % arithNum2);
                    break;
                case "^":
                    Console.WriteLine(Convert.ToInt32(arithNum1) ^ Convert.ToInt32(arithNum2));
                    break;
                default:
                    Console.WriteLine("An invalid operator was entered. The equation won't be calculated. Press any key to terminate the console.");
                    break;
            }
        }

        static void CalculatorTrigonometry()
        {
            string trigFunc;

            Console.WriteLine("Enter a number.");
            trigNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter one of the following trigonometric functions. Please type in all lowercase. \nsin, cos, tan, csc, sec, cot");
            trigFunc = Console.ReadLine();

            switch (trigFunc)
            {
                case "sin":
                    Console.WriteLine(Math.Sin(trigNum));
                    break;
                case "cos":
                    Console.WriteLine(Math.Cos(trigNum));
                    break;
                case "tan":
                    Console.WriteLine(Math.Tan(trigNum));
                    break;
                case "csc":
                    Console.WriteLine(1 / Math.Sin(trigNum));
                    break;
                case "sec":
                    Console.WriteLine(1 / Math.Cos(trigNum));
                    break;
                case "cot":
                    Console.WriteLine(1 / Math.Tan(trigNum));
                    break;
                default:
                    Console.WriteLine("An invalid trigonometric function was entered. Press any key to terminate the console.");
                    break;
            }
        }

        static void CalculatorAbsolute()
        {
            Console.WriteLine("Enter a number to find its absolute value.");
            absNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Abs(absNum));
        }
    }
}