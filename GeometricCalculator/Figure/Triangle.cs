using System;
using System.Linq;

namespace GeometricCalculator.Figure
{
    public class Triangle : Figure2D
    {
        private double ASide { get; set; }
        private double BSide { get; set; }
        private double CSide { get; set; }

        public bool IsRightAngle { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Каждая сторона должна быть больше 0");

            var sides = new[] { a, b, c };
            Array.Sort(sides);
            if (sides[2] > sides[0] + sides[1])
                throw new ArgumentOutOfRangeException("Одна сторона больше суммы двух других");

            ASide = a; BSide = b; CSide = c;

            IsRightAngle = IsRightAngleClac();
        }

        public override double CalcSquare()
        {
            var p = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        private bool IsRightAngleClac()
        {
            var maxSide = new[] { ASide, BSide, CSide }.Max();
            return 2 * Math.Pow(maxSide, 2) == Math.Pow(ASide, 2) + Math.Pow(BSide, 2) + Math.Pow(CSide, 2);
        }
    }
}
