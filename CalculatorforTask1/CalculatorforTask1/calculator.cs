using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorforTask1
{
    public class calculator
    {
        //Addition function
        public double Add(double a, double b)
        {
            return a + b;
        }

        //Subtraction function
        public double Sub(double a, double b)
        {
            return a - b;
        }

        //Multiplication function
        public double Mul(double a, double b)
        {
            return a * b;
        }

        //Division function
        public double Div(double a, double b)
        {
            return a / b;
        }

        //Percent function
        public double Percent(double a, double b)
        {
            return a * b / 100;
        }

        //Power function
        public double Power(double a, double b)
        {
            return Math.Pow(a,b);
        }

        //Root function
        public double Root(double a, double b)
        {
            return Math.Pow(a, 1.0 / b);
        }
    }
}
