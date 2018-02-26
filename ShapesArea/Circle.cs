using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesArea
{
    public class Circle : IArea
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}
