using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public struct PointVal
    {
        public int X;
        public int Y;

        public void Logvalues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public void Logvalues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }
}
