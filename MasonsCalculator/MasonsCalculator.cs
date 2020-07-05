// Mason's Calculator v0.3.0
// Written in Visual Studio 2019 using .NET Core 3.1
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Transactions;

namespace MasonsCalculator
{
    class MasonsCalculator
    { 
        static void Main(string[] args)
        {
            string function;

            Console.WriteLine("Welcome to Mason's Calculator v0.2.0. Which of the following functions do you want to perform? Please type in all uppercase.\nARITHMETIC, TRIGONOMETRY, INVERSE TRIGONOMETRY, ABSOLUTE VALUES\nLOGARITHMS, NATURAL LOGARITHMS, SQUARE ROOTS");
            function = Console.ReadLine();

            switch (function)
            {
                case "ARITHMETIC":
                    CalculatorArithmetic();
                    break;
                case "TRIGONOMETRY":
                    CalculatorTrigonometry();
                    break;
                case "INVERSE TRIGONOMETRY":
                    CalculatorInverseTrig();
                    break;
                case "ABSOLUTE VALUES":
                    CalculatorAbsolute();
                    break;
                case "LOGARITHMS":
                    CalculatorLogarithms();
                    break;
                case "NATURAL LOGARITHMS":
                    CalculatorNaturalLogs();
                    break;
                case "SQUARE ROOTS":
                    CalculatorSquareRoots();
                    break;
                default:
                    Console.WriteLine("An invalid function was entered. Press any key to terminate the console.");
                    break;
            }
        }

        static void CalculatorArithmetic()
        {
            double arithNum1;
            double arithNum2;
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
                    Console.WriteLine("An invalid operator was entered. Press any key to terminate the console.");
                    break;
            }
        }

        static void CalculatorInverseTrig()
        {
            double invTrigNum;
            string invTrigFunc;

            Console.WriteLine("Enter a number.");
            invTrigNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter one of the following inverse trigonometric functions. Please type in all lowercase.\narcsin, arccos, arctan, arccsc, arcsec, arccot");
            invTrigFunc = Console.ReadLine();

            switch (invTrigFunc)
            {
                case "arcsin":
                    Console.WriteLine(Math.Asin(invTrigNum));
                    break;
                case "arccos":
                    Console.WriteLine(Math.Acos(invTrigNum));
                    break;
                case "arctan":
                    Console.WriteLine(Math.Atan(invTrigNum));
                    break;
                case "arccsc":
                    Console.WriteLine(Math.Asin(1 / invTrigNum));
                    break;
                case "arcsec":
                    Console.WriteLine(Math.Acos(1 / invTrigNum));
                    break;
                case "arccot":
                    Console.WriteLine(Math.Atan(1 / invTrigNum));
                    break;
                default:
                    Console.WriteLine("An invalid inverse trigonometric function was entered. Press any key to terminate the console.");
                    break;
            }
        }
        static void CalculatorTrigonometry()
        {
            double trigNum;
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
            double absNum;
            
            Console.WriteLine("Enter a number to find its absolute value.");
            absNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Abs(absNum));
        }

        static void CalculatorLogarithms()
        {
            double logNum;

            Console.WriteLine("Enter a number to find its logarithm.");
            logNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Log10(logNum));
        }

        static void CalculatorNaturalLogs()
        {
            double naturalLogNum;

            Console.WriteLine("Enter a number to find its natural logarithm");
            naturalLogNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Log(naturalLogNum));
        }

        static void CalculatorSquareRoots()
        {
            double sqrtNum;

            Console.WriteLine("Enter a number to find its square root");
            sqrtNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(sqrtNum));
        }
    }
}