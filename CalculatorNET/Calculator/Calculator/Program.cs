using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();

            string n1b, n2b;
            double n1 = 0.0;
            double n2 = 0.0;

            Console.WriteLine("Type your First Number...");

            n1b = Console.ReadLine();
            bool isNumeric = double.TryParse(n1b, out _);
            bool isEquation = n1b.Contains("+") || n1b.Contains("-") || n1b.Contains("*") || n1b.Contains("/");

            if (isEquation == true) {
                Console.WriteLine("Please enter a number(Not an equation)");
                Thread.Sleep(2000);
                goto Start;
            } else if(isNumeric == true && isEquation == false) {
                n1 = Convert.ToDouble(n1b);
                Console.Clear();
            }else {
                Console.WriteLine("Enter a real number");
                Thread.Sleep(1000);
                Console.Clear();
                goto Start;
            }

            Console.WriteLine("Type your Second Number... (Type any random number to use sqrt function)");

            n2b = Console.ReadLine();
            bool isNumeric2 = double.TryParse(n2b, out _);

            if (isNumeric2 == true)
            {
                n2 = Convert.ToDouble(n2b);
                Console.Clear();
            } else
            {
                Console.Clear();
                goto Start;
            }

            Console.WriteLine("Choose an Operation:");
            Console.WriteLine("a = add");
            Console.WriteLine("s = subtract");
            Console.WriteLine("m = multiply");
            Console.WriteLine("d = divide");
            Console.WriteLine("mod = modulus | remainder of num1 / num2");
            Console.WriteLine("sqrt = sqare root | square root of num1");
            Console.WriteLine("pow = Power | num1 ^ num2");

            switch (Console.ReadLine())
            {
                case "a":
                    double a = Functions.Add(n1, n2);
                    if (a == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                    break;
                case "s":
                    double s = Functions.Subtract(n1, n2);
                    if (s == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case "m":
                    double m = Functions.Multiply(n1, n2);
                    if (m == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(m);
                    }
                    break;
                case "d":
                    double d = Functions.Divide(n1, n2);
                    if (d == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(d);
                    }
                    break;
                case "mod":
                    double mod = Functions.Modulo(n1, n2);
                    if (mod == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(mod);
                    }
                    break;
                case "sqrt":
                    double sqrt = Functions.Sqroot(n1);
                    if (sqrt == Convert.ToDouble("∞"))
                    {
                        Console.WriteLine("Number is too high");
                    }
                    else
                    {
                        Console.WriteLine(sqrt);
                    }
                    break;
                case "pow":
                    double pow = Functions.Power(n1, n2);
                    if (pow == Convert.ToDouble("∞")) {
                        Console.WriteLine("Number is too high");
                    } else
                    {
                        Console.WriteLine(pow);
                    }
                    break;
            }

            Console.WriteLine("Press E too restart Calculator");
            Console.WriteLine("Press any other key to close the Console");
            if(Console.ReadKey(true).Key == ConsoleKey.E)
            {
                Console.Clear();
                goto Start;
            }
        }
    }
}
