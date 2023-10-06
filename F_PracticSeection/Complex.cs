using System;
using System.Collections.Generic;
using System.Text;

namespace F_PracticSeection
{
    class Complex
    {
        public double RealPart { get; private set; }
        public double ImaginaryPart { get; private set; }

        public Complex(double realPart, double imaginaryPart)
        {
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }

        public Complex ComplexAdditions(Complex secondComplex)
        {
            Complex result = new Complex(RealPart + secondComplex.RealPart, ImaginaryPart + secondComplex.ImaginaryPart);
            return result;
        }

        public Complex ComplexSubtraction(Complex secondComplex)
        {
            Complex result = new Complex(RealPart - secondComplex.RealPart, ImaginaryPart - secondComplex.ImaginaryPart);
            return result;
        }
    }
}
