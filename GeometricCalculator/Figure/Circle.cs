using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator.Figure
{
    public class Circle : Figure2D
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        override public double CalcSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
