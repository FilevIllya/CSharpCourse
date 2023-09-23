﻿using System;
using System.Collections.Generic;

namespace D_OOP
{
    class Program 
    {
        static void Main(string[] args)
        {
            Character c = new Character("Elf");
            Console.WriteLine(c.Race);
        }
        ////////
        static void BoxingUnboxing()
        {
            int x = 1;
            object obj = x; //boxing

            int y = (int)obj; //unboxing 

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)(double)obj1; //error: int number = (int)obj1;
            Console.WriteLine(number);
        }
        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef; //check type
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
            }
            else
            {
                //do something
            }

            PointRef pr1 = obj as PointRef; //check type. set null if bad type
            if (pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }
            else
            {
                //do something
            }
        }

        ////////
        static void NRE_NullableValTypesDemo()
        {
            PointVal? pv = null; //not null
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value);
                Console.WriteLine(pv2.X);
            }
            else
            {
                // if null
            }

            PointVal pv3 = pv.GetValueOrDefault(); //set all values in struct in default

            PointRef c = null; // ==PointRef c = null;
            Console.WriteLine(c.X); //NullReferenceException
        }
        ////////
        static void PassByRefDemo()
        {
            int a = 1;
            int b = 2;
            Swap(ref a, ref b);
            Console.WriteLine($" a={a}, b={b}"); //no swap outside, only in method. Need word "ref" in method params

            Console.ReadLine();


            List<int> list = new List<int>(); //link to memory where is list
            AddNumbers(list);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
        static void Swap(ref int a,ref int b)
        {
            Console.WriteLine($"Original a={a}, b={b}");
            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine($"Swapped a={a}, b={b}");
        }
        static void AddNumbers(List<int> numbers) //also link to same List
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
        }
        ////////
        static void RefAndValTypes()
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { X = 1, Y = 2 };
            //Or
            //es1.PointRef.X = 1;
            //es1.PointRef.Y = 2;
            EvilStruct es2 = es1;

            Console.WriteLine($"es1.PointRef.X = {es1.PointRef.X}, es1.PointRef.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X = {es2.PointRef.X}, es2.PointRef.Y = {es2.PointRef.Y}");

            es2.PointRef.X = 42;
            es2.PointRef.Y = 45;

            Console.ReadLine();
            Console.WriteLine($"es1.PointRef.X = {es1.PointRef.X}, es1.PointRef.Y = {es1.PointRef.Y}");
            Console.WriteLine($"es2.PointRef.X = {es2.PointRef.X}, es2.PointRef.Y = {es2.PointRef.Y}");

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
