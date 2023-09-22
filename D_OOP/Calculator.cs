using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public static class Calculator
    {
        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            else
            {
                result = divisible / divisor;
                return true;
            }
        }
        public static double Avarage(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public static double Avarage2(params int[] numbers) //params must be last one
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public static double GetTriangleSquare(double side1, double side2, double side3) //by Geron
        {
            double p = (side1 + side2 + side3) / 2;

            return Math.Sqrt(p * ((p - side1) * (p - side2) * (p - side3)));
        }
        public static double GetTriangleSquare(double b, double h)
        {
            return 0.5 * b * h;
        }

        public static double GetTriangleSquare(double side1, double side2, int alpha, bool isInRadians = false)
        {
            if (isInRadians)
            {
                return 0.5 * side1 * side2 * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI * 180;
                return 0.5 * side1 * side2 * Math.Sin(rads);
            }

        }
    }
}
