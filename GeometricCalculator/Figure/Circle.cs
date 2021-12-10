using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator.Figure
{
    class Circle : ISquare
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalcSquare()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2);
        }
    }
}
