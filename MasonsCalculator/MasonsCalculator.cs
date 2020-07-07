// Mason's Calculator v1.0-rc2
// Written in Visual Studio 2019 using .NET Core 3.1
using System;
using System.Runtime.InteropServices;

namespace MasonsCalculator
{
    class MasonsCalculator
    {

        static void Main(string[] args)
        {
            string mathFunc;

            Console.WriteLine("Welcome to Mason's Calculator. Type in one of the following functions to perform or type 'Quit' to quit the program.\nArithmetic, Trigonometry, Inverse Trigonometry\nAbsolute Values, Logarithms, Natural Logarithms\nPercentages, Exponents, Square Roots");
            mathFunc = Console.ReadLine();

            switch (mathFunc)
            {
                case "Arithmetic":
                    Console.Clear();
                    CalculatorArithmetic();
                    break;
                case "Trigonometry":
                    Console.Clear();
                    CalculatorTrigonometry();
                    break;
                case "Inverse Trigonometry":
                    Console.Clear();
                    CalculatorInverseTrig();
                    break;
                case "AbsoluteValues":
                    Console.Clear();
                    CalculatorAbsolute();
                    break;
                case "Logarithms":
                    Console.Clear();
                    CalculatorLogarithms();
                    break;
                case "Natural Logarithms":
                    Console.Clear();
                    CalculatorNaturalLogs();
                    break;
                case "Percentages":
                    Console.Clear();
                    CalculatorPercentages();
                    break;
                case "Exponents":
                    Console.Clear();
                    CalculatorExponents();
                    break;
                case "Square Roots":
                    Console.Clear();
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

        static void CalculatorPercentages()
        {
            int perNum;

            Console.WriteLine("Enter the percentage.");
            perNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(perNum / 100);
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