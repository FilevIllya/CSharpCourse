﻿using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shape
    {
        //I cant create value from abstract class
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }
        public abstract void Draw();

        public abstract double Area();

        public abstract double Perimetr();
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine("Triangle Created.");
        }

        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s*(s-ab)*(s-bc)*(s-ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimetr()
        {
            return ab+bc+ac;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectangle Created.");
        }
        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimetr()
        {
            return 2 * (width + height);
        }
    }
}
