using System;
using MathOperations;

namespace basiccalculator
{
    public class Calculator
    {
        static public int Add(int a, int b)
        {
            return 0;
            //return Addition.Sum(a,b);
        }
        static public int Subtract(int a, int b)
        {
            var c = a - b;

            return c;
        }

        static public int Multiply(int a, int b)
        {
            var c = a * b;

            return c;
        }

        static public double Divide(int a, int b)
        {
            var c = a / b;

            return c;
        }
        // add square and square root
    }
}
