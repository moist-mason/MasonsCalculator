// Mason's Calculator v1.0-rc1
// Written in Visual Studio 2019 using .NET Core 3.1
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {

        static void Main(string[] args)
        {
            string mathFunc;

            Console.WriteLine("Welcome to Mason's Calculator RC1. Type in one of the following functions to perform or type 'Quit' to quit the program.\nArithmetic, Trigonometry, Inverse Trigonometry, Absolute Values, Logarithms, Natural Logarithms, Exponents, Square Roots");
            mathFunc = Console.ReadLine();

            switch (mathFunc)
            {
                case "Arithmetic":
                    CalculatorArithmetic();
                    break;
                case "Trigonometry":
                    CalculatorTrigonometry();
                    break;
                case "Inverse Trigonometry":
                    CalculatorInverseTrig();
                    break;
                case "AbsoluteValues":
                    CalculatorAbsolute();
                    break;
                case "Logarithms":
                    CalculatorLogarithms();
                    break;
                case "Natural Logarithms":
                    CalculatorNaturalLogs();
                    break;
                case "Exponents":
                    CalculatorExponents();
                    break;
                case "Square Roots":
                    CalculatorSquareRoots();
                    break;
                case "Quit":
                    Environment.Exit(0);
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
            string arithOp;

            Console.WriteLine("First, enter a number.");
            arithNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Next, enter another number.");
            arithNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Finally, enter one of the following operators:\n+, -, *, /, %, ^");
            arithOp = Convert.ToString(Console.ReadLine());

            switch (arithOp)
            {
                case "+":
                    Console.WriteLine(arithNum1 + arithNum2);
                    break;
                case "-":
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
                default:
                    Console.WriteLine("An invalid operator was entered. Press any key to terminate the console.");
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

            Console.WriteLine("Enter a number to find its natural logarithm.");
            naturalLogNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Log(naturalLogNum));
        }

        static void CalculatorExponents()
        {
            int baseNum;
            int powNum;

            Console.WriteLine("Enter your base number.");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your power number.");
            powNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(baseNum ^ powNum);
        }
       
        static void CalculatorSquareRoots()
        {
            double sqrtNum;

            Console.WriteLine("Enter a number to find its square root.");
            sqrtNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(sqrtNum));
        }
    }
}