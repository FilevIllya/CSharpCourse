using System;

namespace D_OOP
{
    class Program 
    {
        static void Main(string[] args)
        {
            RomanToArabian rTA = new RomanToArabian();
            int arabianNumber = rTA.Convert("XCIX");
            Console.WriteLine(arabianNumber);
        }

        static void OOPTest()
        {
            //Character c = new Character();
            //c.Hit(120); //side effect

            //Console.WriteLine(c.Health);

            Calculator calc = new Calculator();
            double square1 = calc.GetTriangleSquare(10, 20);
            double square2 = calc.GetTriangleSquare(40, 20, 30);
            Console.WriteLine($"Square 1 = {square1}; Square 2 = {square2}");
        }
    }
}
