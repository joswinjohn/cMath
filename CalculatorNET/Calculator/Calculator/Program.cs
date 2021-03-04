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
        //Request Function 1
        public static double Request1()
        {
        Start:
            Console.Clear();
            
            Console.WriteLine("Type your First Number...");
            string n1b = Console.ReadLine();

            //process first num
            double n1 = 0.0;

            bool isNumeric = double.TryParse(n1b, out _);

            if (isNumeric == true)
            {
                n1 = Convert.ToDouble(n1b);
                Console.Clear();
            }
            else
            {
                //if the arg isn't an equation or a number
                Console.WriteLine("Enter a real number");
                Thread.Sleep(1000);
                Console.Clear();
                goto Start;
            }
            return n1;
        }

        //Request Function 2
        public static double Request2()
        {
        Start:
            Console.Clear();

            Console.WriteLine("Type your Second Number... (Type any random number to use sqrt function)");
            string n2b = Console.ReadLine();

            //process second num
            double n2 = 0.0;
            
            bool isNumeric2 = double.TryParse(n2b, out _);

            if (isNumeric2 == true)
            {
                n2 = Convert.ToDouble(n2b);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Enter a real number");
                Thread.Sleep(1000);
                Console.Clear();
                goto Start;
            }
            return n2;
        }
        
        static void Main(string[] args)
        {
        Start:
            //clear the console when calling "goto Start;"
            Console.Clear();

            //expaination
            Console.WriteLine("Choose an Operation:");
            Console.WriteLine("a = add");
            Console.WriteLine("s = subtract");
            Console.WriteLine("m = multiply");
            Console.WriteLine("d = divide");
            Console.WriteLine("r = round | rounds to the closest interger");
            Console.WriteLine("cos = gets the cos of the number");
            Console.WriteLine("sin = gets the sine of the number");
            Console.WriteLine("mod = modulus | remainder of num1 / num2");
            Console.WriteLine("sqrt = sqare root | square root of num1");
            Console.WriteLine("pow = Power | num1 ^ num2");
            Console.WriteLine("cel = ceiling");
            Console.WriteLine("cos = co sine");
            Console.WriteLine("sin = sine");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.Clear();
                    
                    //call and run request functions
                    double wrt1 = Request1();
                    double wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Add(wrt1, wrt2));

                    break;
                case "s":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();
                    wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Subtract(wrt1, wrt2));

                    break;
                case "m":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();
                    wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Multiply(wrt1, wrt2));

                    break;
                case "d":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();
                    wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Divide(wrt1, wrt2));

                    break;
                case "mod":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();
                    wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Modulo(wrt1, wrt2));

                    break;
                case "sqrt":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Sqroot(wrt1));

                    break;
                case "pow":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();
                    wrt2 = Request2();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Power(wrt1, wrt2));

                    break;
                case "r":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Round(wrt1));

                    break;
                case "cel":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Celling(wrt1));

                    break;
                case "cos":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Cos(wrt1));

                    break;
                case "sin":
                    Console.Clear();
                    //call and run request functions
                    wrt1 = Request1();

                    //run Calculator.Functions.cs operator function and Write Line
                    Console.WriteLine(Functions.Sin(wrt1));

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
