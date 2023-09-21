using System;

namespace D_OOP
{
    class Program 
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double avg = calc.Avarage(new int[] {1,2,3,4,5,6 }); 
            Console.WriteLine(avg);
            //=====
            double avg2 = calc.Avarage2(1, 2, 3, 4, 5, 6 );
            Console.WriteLine(avg2);

            //////////////name arguments
            calc.GetTriangleSquare(side1: 10, side2: 20, side3:30);
        }

        static void RomanNumbers()
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
