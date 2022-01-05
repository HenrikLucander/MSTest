using System;

namespace Calculator.Library
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new DivideByZeroException("Denominator can not be zero");
            }

            int result = numerator / denominator;
            return result;
        }

        //public int Add(int fn, int sn)
        public static int Add(int fn, int sn)
        {
            if(IsPositive(fn) & IsPositive(sn))
            {
                int result = fn + sn;
                return result;
            }
            else
            {
                throw new ArgumentException("Only positive number are allowed");
            }
        }

        //private bool IsPositive(int Number)
        private static bool IsPositive(int Number)
        {
            return Number > 0;
        }
    }
}