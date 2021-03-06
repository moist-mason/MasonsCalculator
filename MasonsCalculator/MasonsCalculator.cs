﻿// Mason's Calculator 1.1
// Written in Visual Studio 2019 using .NET 5.0 Preview 7
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {
        static string restartWord;
        static double num1;
        static double num2;
        static string function;

        // Main() method, used to select which mathematical function the user wants to perform.
        static void Main()
        {
            string category;

            Console.WriteLine("Welcome to Mason's Calculator. Type in one of the following function categories to perform.\nType 'Exit' to exit the program.\n \nArithmetic, Trigonometry, Inverse Trigonometry\nAbsolute Values, Logarithms, Natural Logarithms\nPercentages, Exponents, Roots");
            category = Console.ReadLine();

            switch (category.ToLower())
            {
                case "arithmetic":
                    Console.Clear();
                    CalculatorArithmetic();
                    break;
                case "trigonometry":
                    Console.Clear();
                    CalculatorTrigonometry();
                    break;
                case "inverse trigonometry":
                    Console.Clear();
                    CalculatorInverseTrig();
                    break;
                case "absolute values":
                    Console.Clear();
                    CalculatorAbsolute();
                    break;
                case "logarithms":
                    Console.Clear();
                    CalculatorLogarithms();
                    break;
                case "natural logarithms":
                    Console.Clear();
                    CalculatorNaturalLogs();
                    break;
                case "percentages":
                    Console.Clear();
                    CalculatorPercentages();
                    break;
                case "exponents":
                    Console.Clear();
                    CalculatorExponents();
                    break;
                case "roots":
                    Console.Clear();
                    CalculatorRoots();
                    break;
                case "exit":
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
            bool isPrinted = true;

            if (isPrinted == true)
            {
                Console.WriteLine("The function was successfully performed. Type 'restart' to restart the program.");
                restartWord = Console.ReadLine();

                if (restartWord.ToLower() == "restart")
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
            bool errorOccurred = true;

            if (errorOccurred == true)
            {
                Console.WriteLine("Type 'restart' to restart the program.");
                restartWord = Console.ReadLine();

                if (restartWord.ToLower() == "restart")
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
                char arithOp;

                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a second number.");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter one of the following operators.\n+, -, *, /, %, ^");
                arithOp = Convert.ToChar(Console.ReadLine());

                switch (arithOp)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        RestartWhenSuccessful();
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        RestartWhenSuccessful();
                        break;
                    case '*':
                        Console.WriteLine(num1 * num2);
                        RestartWhenSuccessful();
                        break;
                    case '/':
                        Console.WriteLine(num1 / num2);
                        RestartWhenSuccessful();
                        break;
                    case '%':
                        Console.WriteLine(num1 % num2);
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
                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter one of the following trigonometric functions.\nsin, cos, tan, csc, sec, cot");
                function = Console.ReadLine();

                switch (function.ToLower())
                {
                    case "sin":
                        Console.WriteLine(Math.Sin(num1));
                        RestartWhenSuccessful();
                        break;
                    case "cos":
                        Console.WriteLine(Math.Cos(num1));
                        RestartWhenSuccessful();
                        break;
                    case "tan":
                        Console.WriteLine(Math.Tan(num1));
                        RestartWhenSuccessful();
                        break;
                    case "csc":
                        Console.WriteLine(1 / Math.Sin(num1));
                        RestartWhenSuccessful();
                        break;
                    case "sec":
                        Console.WriteLine(1 / Math.Cos(num1));
                        RestartWhenSuccessful();
                        break;
                    case "cot":
                        Console.WriteLine(1 / Math.Tan(num1));
                        RestartWhenSuccessful();
                        break;
                    default:
                        Console.WriteLine("An invalid function was entered.");
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

                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter one of the following inverse trigonometric functions.\narcsin, arccos, arctan, arccsc, arcsec, arccot");
                function = Console.ReadLine();

                switch (function.ToLower())
                {
                    case "arcsin":
                        Console.WriteLine(Math.Asin(num1));
                        RestartWhenSuccessful();
                        break;
                    case "arccos":
                        Console.WriteLine(Math.Acos(num1));
                        RestartWhenSuccessful();
                        break;
                    case "arctan":
                        Console.WriteLine(Math.Atan(num1));
                        RestartWhenSuccessful();
                        break;
                    case "arccsc":
                        Console.WriteLine(Math.Asin(1 / num1));
                        RestartWhenSuccessful();
                        break;
                    case "arcsec":
                        Console.WriteLine(Math.Acos(1 / num1));
                        RestartWhenSuccessful();
                        break;
                    case "arccot":
                        Console.WriteLine(Math.Atan(1 / num1));
                        RestartWhenSuccessful();
                        break;
                    default:
                        Console.WriteLine("An invalid function was entered.");
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
                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Abs(num1));

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
                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Log10(num1));

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
                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Log(num1));

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
                Console.WriteLine("Enter a number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(num1 / 100);

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
                Console.WriteLine("Enter a base number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an exponent.");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Math.Pow(num1, num2));

                RestartWhenSuccessful();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

                RestartAfterError();
            }
        }

        // The root function. 
        static void CalculatorRoots()
        {
            try
            {
                Console.WriteLine("Enter a base number.");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a root number.");
                num2 = Convert.ToDouble(Console.ReadLine());
                double root = 1 / num2;

                Console.WriteLine(Math.Pow(num1, root));

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