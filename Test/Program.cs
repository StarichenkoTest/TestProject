using System;

namespace Test
{
    public class Program
    {
        public const double Epsilon = 0.0001;

        static public double TriangleArea(double side1, double side2, double side3)
        {
            if (double.IsNaN(side1) || side1 < Epsilon || side1 > 1.3407807929942596E+154)
                throw new ArgumentOutOfRangeException("side1", "Side length must be greater than 0 and less than 1.3407807929942596E+154");

            if (double.IsNaN(side2) || side2 < Epsilon || side2 > 1.3407807929942596E+154)
                throw new ArgumentOutOfRangeException("side2", "Side length must be greater than 0 and less than 1.3407807929942596E+154");

            if (double.IsNaN(side3) || side3 < Epsilon || side3 > 1.3407807929942596E+154)
                throw new ArgumentOutOfRangeException("side3", "Side length must be greater than 0 and less than 1.3407807929942596E+154");

            double a;
            double b;
            double c;
            if (side1 < side2)
            {
                a = side1;
                if (side2 < side3)
                {
                    b = side2;
                    c = side3;
                }
                else
                {
                    b = side3;
                    c = side2;
                }
            }
            else
            {
                a = side2;
                if (side1 < side3)
                {
                    b = side1;
                    c = side3;
                }
                else
                {
                    b = side3;
                    c = side1;
                }
            }
            if (Math.Abs(c - a) < Epsilon || Math.Abs(c - b) < Epsilon || Math.Abs(a*a + b*b - c*c) > Epsilon)
                throw new ArgumentException("A right-angled triangle can not be built from the data sides.");
            
            return b / 2 * a;
        }
        static void Main(string[] args)
        {
            
        }
    }
}