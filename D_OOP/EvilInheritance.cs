using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IShape
    {
        int CalcSquare();
    }
    public class Rect : IShape
    {
        public int Width { get; set; }
        public int Hight { get; set; }

        public int CalcSquare()
        {
            return Width * Hight;
        }
    }

    public class Square : IShape
    {
        public int SideLenght { get; set; }
        public int CalcSquare()
        {
            return SideLenght * SideLenght;
        }
    }

    //public static class AreaCalculator
    //{
    //    public static int CalcSquare(Square square)
    //    {
    //        return square.Width * square.Width;
    //    }

    //    public static int CalcSquare(Rect rect)
    //    {
    //        return rect.Width * rect.Hight;
    //    }
    //} 
}
