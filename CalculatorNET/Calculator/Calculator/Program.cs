using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            string n1b, n2b;
            double n1 = 0.0;
            double n2 = 0.0;

            n1b = Console.ReadLine();
            bool isNumeric = double.TryParse(n1b, out _);

            if(isNumeric == true) {
                n1 = Convert.ToDouble(n1b);
            }

            n2b = Console.ReadLine();
            bool isNumeric2 = double.TryParse(n2b, out _);

            if (isNumeric2 == true)
            {
                n2 = Convert.ToDouble(n2b);
            }
            Console.WriteLine("Choose an Operation:");
            Console.WriteLine("a = add");
            Console.WriteLine("s = subtract");
            Console.WriteLine("m = multiply");
            Console.WriteLine("d = divide");

            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"{n1} + {n2} = " + (n1 + n2));
                break;
                case "s":
                    Console.WriteLine($"{n1} - {n2} = " + (n1 - n2));
                    break;
                case "m":
                    Console.WriteLine($"{n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"{n1} / {n2} = " + (n1 / n2));
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
