using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Functions
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Modulo(double num1, double num2)
        {
            return num1 % num2;
        }

        //New arithmetic here
        public static double Sqroot(double num1)
        {
            return Math.Sqrt(num1);
        }

        public static double Power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public static double Round(double num1)
        {
            return Math.Round(num1);
        }
    }
}
