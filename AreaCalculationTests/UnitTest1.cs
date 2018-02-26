using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;

namespace AreaCalculationTests
{
    [TestClass]
    public class TestShapes
    {
        double precision = 0.00001;
        [TestMethod]
        public void CircleTest()
        {
            double radius = 2;
            IArea circle = new Circle(radius);
            var relativeDiff = Math.Abs(1 - circle.Area / 12.56637);
            Assert.IsTrue(relativeDiff < precision);
        }

        [TestMethod]
        public void RectTriangleTest()
        {
            double catheter1 = 2;
            double catheter2 = 4;
            IArea rectTriangle = new RectTriangle(catheter1, catheter2);
            var relativeDiff = Math.Abs(1 - rectTriangle.Area / 4);
            Assert.IsTrue(relativeDiff < precision);
        }
    }
}
