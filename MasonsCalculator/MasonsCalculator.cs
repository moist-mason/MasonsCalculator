// Mason's Calculator v1.0
// Written in Visual Studio 2019 using .NET Core 3.1
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {
        static bool isPrinted = false;
        static bool errorOccurred = false;
        static string restartWord;

        // Main() method, used to select which mathematical function the user wants to perform.
        static void Main()
        {
            string mathFunc;

            Console.WriteLine("Welcome to Mason's Calculator. Type in one of the following function categories to perform.\nType 'Exit' to exit the program.\n \nArithmetic, Trigonometry, Inverse Trigonometry\nAbsolute Values, Logarithms, Natural Logarithms\nPercentages, Exponents, Square Roots");
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
                case "Absolute Values":
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
                case "Exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("An invalid function category was entered. Press any key to terminate the console.");
                    break;
            }
        }

        // Resets the program once an equation has successfully been calculated. Called in every function method.
        static void RestartWhenSuccessful()
        {
            isPrinted = true;

            if (isPrinted == true)
            {
                Console.WriteLine("The function was successfully performed. Type 'restart' to restart the program.");
                restartWord = Console.ReadLine();

                if (restartWord == "restart")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("The input was not recognized. Press any key to terminate the console.");
                }
            }
        }

        // Restarts the program after an error has occured.
        static void RestartAfterError()
        {
            errorOccurred = true;

            if (errorOccurred == true)
            {
                Console.WriteLine("Type 'restart' to restart the program.");
                restartWord = Console.ReadLine();

                if (restartWord == "restart")
                {
                    Console.Clear();
                    Main();
                }
                else
                {
                    Console.WriteLine("The input was not recognized. Press any key to terminate the console.");
                }
            }
        }

        // The arithmetic set of functions (addition, subtraction, multiplication, division, and modular).
        static void CalculatorArithmetic()
        {
            try
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
                        RestartWhenSuccessful();
                        break;
                    case "-":
                        Console.WriteLine(arithNum1 - arithNum2);
                        RestartWhenSuccessful();
                        break;
                    case "*":
                        Console.WriteLine(arithNum1 * arithNum2);
                        RestartWhenSuccessful();
                        break;
                    case "/":
                        Console.WriteLine(arithNum1 / arithNum2);
                        RestartWhenSuccessful();
                        break;
                    case "%":
                        Console.WriteLine(arithNum1 % arithNum2);
                        RestartWhenSuccessful();
                        break;
                    default:
                        Console.WriteLine("An invalid operator was entered.");
                        RestartAfterError();
                        break;
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The trigonometric set of functions (sine, cosine, tangent, cosecant, secant, and cotangent).
        static void CalculatorTrigonometry()
        {
            try
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
                        RestartWhenSuccessful();
                        break;
                    case "cos":
                        Console.WriteLine(Math.Cos(trigNum));
                        RestartWhenSuccessful();
                        break;
                    case "tan":
                        Console.WriteLine(Math.Tan(trigNum));
                        RestartWhenSuccessful();
                        break;
                    case "csc":
                        Console.WriteLine(1 / Math.Sin(trigNum));
                        RestartWhenSuccessful();
                        break;
                    case "sec":
                        Console.WriteLine(1 / Math.Cos(trigNum));
                        RestartWhenSuccessful();
                        break;
                    case "cot":
                        Console.WriteLine(1 / Math.Tan(trigNum));
                        RestartWhenSuccessful();
                        break;
                    default:
                        Console.WriteLine("An invalid trigonometric function was entered.");
                        RestartAfterError();
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The inverse trigonometric set of functions (arcsine, arccosine, arctangent, arccosecant, arcsecant, and arccotangent).
        static void CalculatorInverseTrig()
        {
            try
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
                        RestartWhenSuccessful();
                        break;
                    case "arccos":
                        Console.WriteLine(Math.Acos(invTrigNum));
                        RestartWhenSuccessful();
                        break;
                    case "arctan":
                        Console.WriteLine(Math.Atan(invTrigNum));
                        RestartWhenSuccessful();
                        break;
                    case "arccsc":
                        Console.WriteLine(Math.Asin(1 / invTrigNum));
                        RestartWhenSuccessful();
                        break;
                    case "arcsec":
                        Console.WriteLine(Math.Acos(1 / invTrigNum));
                        RestartWhenSuccessful();
                        break;
                    case "arccot":
                        Console.WriteLine(Math.Atan(1 / invTrigNum));
                        RestartWhenSuccessful();
                        break;
                    default:
                        Console.WriteLine("An invalid inverse trigonometric function was entered.");
                        RestartAfterError();
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The absolute value function.
        static void CalculatorAbsolute()
        {
            try
            {
                double absNum;

                Console.WriteLine("Enter a number to find its absolute value.");
                absNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Abs(absNum));

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The logarithm function (base 10).
        static void CalculatorLogarithms()
        {
            try
            {
                double logNum;

                Console.WriteLine("Enter a number.");
                logNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Log10(logNum));

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The natural logarithm / ln function.
        static void CalculatorNaturalLogs()
        {
            try
            {
                double naturalLogNum;

                Console.WriteLine("Enter a number.");
                naturalLogNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Log(naturalLogNum));

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The percentage function (converts a number into a percentage decimal form, AKA divides the number by 100). 
        static void CalculatorPercentages()
        {
            try
            {
                double perNum;

                Console.WriteLine("Enter a number.");
                perNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(perNum / 100);

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The exponent function.
        static void CalculatorExponents()
        {
            try
            {
                int baseNum;
                int powNum;

                Console.WriteLine("Enter a base number.");
                baseNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an exponent.");
                powNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(baseNum ^ powNum);

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }

        // The square root function.
        static void CalculatorSquareRoots()
        {
            try
            {
                double sqrtNum;

                Console.WriteLine("Enter a number.");
                sqrtNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sqrtNum));

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                RestartAfterError();
            }
        }
    }
}