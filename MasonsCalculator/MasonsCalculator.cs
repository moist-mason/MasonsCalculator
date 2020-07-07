// Mason's Calculator v1.0-rc3
// Written in Visual Studio 2019 using .NET Core 3.1
using System;

namespace MasonsCalculator
{
    class MasonsCalculator
    {
        // Set to true once an equation has been successfully calculated, which in turn activates the ResetWhenSuccessful() method.
        static bool isPrinted = false;

        // Main() method, used to select which mathematical function the user wants to perform.
        static void Main()
        {
            string mathFunc;

            Console.WriteLine("Welcome to Mason's Calculator. Type in one of the following function categories to perform or type 'Quit' to quit the program.\nArithmetic, Trigonometry, Inverse Trigonometry\nAbsolute Values, Logarithms, Natural Logarithms\nPercentages, Exponents, Square Roots");
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
                    Console.WriteLine("An invalid function category was entered. Press any key to terminate the console.");
                    break;
            }
        }

        // Resets the program once an equation has successfully been calculated. Called in every function method.
        static void ResetWhenSuccessful()
        {
            isPrinted = true;
            string resetWord;
            
            if (isPrinted == true)
            {
                Console.WriteLine("The equation was successfully calculated. Type 'Reset' to restart the program.");
                resetWord = Console.ReadLine();

                if (resetWord == "Reset")
                {
                    Console.Clear();
                    Main();
                }
                else 
                {
                    Console.WriteLine("Input not regonized. Press any key to terminate the console.");
                }
            }
        }

        // The arithmetic set of functions (addition, subtraction, multiplication, division, and modular).
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
                    ResetWhenSuccessful();
                    break;
                case "-":
                    Console.WriteLine(arithNum1 - arithNum2);
                    ResetWhenSuccessful();
                    break;
                case "*":
                    Console.WriteLine(arithNum1 * arithNum2);
                    ResetWhenSuccessful();
                    break;
                case "/":
                    Console.WriteLine(arithNum1 / arithNum2);
                    ResetWhenSuccessful();
                    break;
                case "%":
                    Console.WriteLine(arithNum1 % arithNum2);
                    ResetWhenSuccessful();
                    break;
                default:
                    Console.WriteLine("An invalid operator was entered. Press any key to terminate the console.");
                    break;
            }
        }

        // The trigonometric set of functions (sine, cosine, tangent, cosecant, secant, and cotangent).
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
                    ResetWhenSuccessful();
                    break;
                case "cos":
                    Console.WriteLine(Math.Cos(trigNum));
                    ResetWhenSuccessful();
                    break;
                case "tan":
                    Console.WriteLine(Math.Tan(trigNum));
                    ResetWhenSuccessful();
                    break;
                case "csc":
                    Console.WriteLine(1 / Math.Sin(trigNum));
                    ResetWhenSuccessful();
                    break;
                case "sec":
                    Console.WriteLine(1 / Math.Cos(trigNum));
                    ResetWhenSuccessful();
                    break;
                case "cot":
                    Console.WriteLine(1 / Math.Tan(trigNum));
                    ResetWhenSuccessful();
                    break;
                default:
                    Console.WriteLine("An invalid trigonometric function was entered. Press any key to terminate the console.");
                    break;
            }
        }

        // The inverse trigonometric set of functions (arcsine, arccosine, arctangent, arccosecant, arcsecant, and arccotangent).
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
                    ResetWhenSuccessful();
                    break;
                case "arccos":
                    Console.WriteLine(Math.Acos(invTrigNum));
                    ResetWhenSuccessful();
                    break;
                case "arctan":
                    Console.WriteLine(Math.Atan(invTrigNum));
                    ResetWhenSuccessful();
                    break;
                case "arccsc":
                    Console.WriteLine(Math.Asin(1 / invTrigNum));
                    ResetWhenSuccessful();
                    break;
                case "arcsec":
                    Console.WriteLine(Math.Acos(1 / invTrigNum));
                    ResetWhenSuccessful();
                    break;
                case "arccot":
                    Console.WriteLine(Math.Atan(1 / invTrigNum));
                    ResetWhenSuccessful();
                    break;
                default:
                    Console.WriteLine("An invalid inverse trigonometric function was entered. Press any key to terminate the console.");
                    break;
            }
        }

        // The absolute value function.
        static void CalculatorAbsolute()
        {
            double absNum;

            Console.WriteLine("Enter a number to find its absolute value.");
            absNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Abs(absNum));

            ResetWhenSuccessful();
        }

        // The logarithm function (base 10).
        static void CalculatorLogarithms()
        {
            double logNum;

            Console.WriteLine("Enter a number to find its logarithm.");
            logNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Log10(logNum));

            ResetWhenSuccessful();
        }

        // The natural logarithm / ln function.
        static void CalculatorNaturalLogs()
        {
            double naturalLogNum;

            Console.WriteLine("Enter a number to find its natural logarithm.");
            naturalLogNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Log(naturalLogNum));

            ResetWhenSuccessful();
        }

        // The percentage function (converts a number into a percentage decimal form). 
        static void CalculatorPercentages()
        {
            int perNum;

            Console.WriteLine("Enter a number to find its percentage decimal form.");
            perNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(perNum / 100);

            ResetWhenSuccessful();
        }

        // The exponent function.
        static void CalculatorExponents()
        {
            int baseNum;
            int powNum;

            Console.WriteLine("Enter your base number.");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your power number.");
            powNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(baseNum ^ powNum);

            ResetWhenSuccessful();
        }
       
        // The square root function.
        static void CalculatorSquareRoots()
        {
            double sqrtNum;

            Console.WriteLine("Enter a number to find its square root.");
            sqrtNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(sqrtNum));

            ResetWhenSuccessful();
        }
    }
}