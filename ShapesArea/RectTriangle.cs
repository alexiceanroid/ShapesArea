using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesArea
{
    public class RectTriangle : IArea
    {
        private double _catheter1;
        private double _catheter2;
        private double _hypotenuse;

        public RectTriangle(double catheter1, double catheter2)
        {
            _catheter1 = catheter1;
            _catheter2 = catheter2;
            _hypotenuse = Math.Sqrt(Math.Pow(_catheter1, 2) + Math.Pow(_catheter2, 2));
        }

        public double Area => _catheter1 * _catheter2 / 2;
    }
}