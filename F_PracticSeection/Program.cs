using System;

namespace F_PracticSeection
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 1);

            Complex result = c1.ComplexSubtraction(c2);
            Console.WriteLine($"Your complex number is {result.RealPart}+{result.ImaginaryPart}i");
        }
    }
}
