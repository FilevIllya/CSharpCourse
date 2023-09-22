using System;

namespace D_OOP
{
    class Program 
    {
        static void Main(string[] args)
        {
            PointVal a; //same as PointVal a = new PointVal();
            a.X = 3;
            a.Y = 5;

            PointVal b = a;
            b.X = 7;
            b.Y = 10;

            a.Logvalues();
            b.Logvalues();
            //////
            Console.WriteLine("After structs");

            PointRef c = new PointRef(); ;
            c.X = 3;
            c.Y = 5;

            PointRef d = c;
            d.X = 7;
            d.Y = 10;

            c.Logvalues();
            d.Logvalues();

        }

        static void StaticTest()
        {
            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1.Speed = {c1.PrintSpeed()} c2.Speed = {c2.PrintSpeed()}");

            c1.IncreaseSpeed();

            Console.WriteLine($"c1.Speed = {c1.PrintSpeed()} c2.Speed = {c2.PrintSpeed()}");

            double result = Calculator.Avarage2(1, 2, 3, 5);
            Console.WriteLine(result);
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

            //Calculator calc = new Calculator();
            //double square1 = calc.GetTriangleSquare(10, 20);
            //double square2 = calc.GetTriangleSquare(40, 20, 30);
            //Console.WriteLine($"Square 1 = {square1}; Square 2 = {square2}");
        }
        static void MethodParametrs()
        {
            ////USE WITHOUT STATIC
            //Calculator calc = new Calculator();
            //double avg = calc.Avarage(new int[] { 1, 2, 3, 4, 5, 6 });
            //Console.WriteLine(avg);
            ////=====
            //double avg2 = calc.Avarage2(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(avg2);

            ////////////////name arguments
            //calc.GetTriangleSquare(side1: 10, side2: 20, side3: 30);


            ////////////////out
            //if (calc.TryDivide(10, 2, out double result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to divade");
            //}

            //Console.ReadLine();
            //Console.WriteLine("Enter a number, please.");

            //string line = Console.ReadLine();
            //bool wasParsed = int.TryParse(line, out int number);
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse");
            //}

            ////
        }
    }
}
