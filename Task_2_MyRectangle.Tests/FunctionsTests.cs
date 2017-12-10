using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2_ArturDovbysh;

namespace Task_2_MyRectangle.Tests
{
    [TestClass]
    public class FunctionsTests
    {
        [TestMethod]
        public void GetPerimeter_ShouldReturn_ExpectedValues()
        {
            bool flag = true; //for more than one test

            MyRectangle rect = new MyRectangle(new Point2D(1, 1), 10, 20);
            int expected = 60;

            if (rect.GetPerimeter() != expected)
                flag = false;

            rect = new MyRectangle(15, 15);

            if (rect.GetPerimeter() != expected)
                flag = false;

            rect = new MyRectangle(0, 0);
            expected = 0;

            if (rect.GetPerimeter() != expected)
                flag = false;

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void GetSquare_ShouldReturn_ExpectedValues()
        {
            bool flag = true; //for more than one test

            MyRectangle rect = new MyRectangle(new Point2D(1, 1), 10, 20);
            int expected = 200;

            if (rect.GetSquare() != expected)
                flag = false;

            rect = new MyRectangle(1, 6);
            expected = 6;

            if (rect.GetSquare() != expected)
                flag = false;

            rect = new MyRectangle(0, 0);
            expected = 0;

            if (rect.GetSquare() != expected)
                flag = false;

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void BuildIntersection_SouldReturn_CorrectRectangle()
        {
            MyRectangle r1 = new MyRectangle(10, 10);
            MyRectangle r2 = new MyRectangle(new Point2D(-1, -2), 13, 13);
            MyRectangle r3 = MyRectangle.BuildIntersection(r1, r2);

            bool isCorrect = r3.Peak.X == 0 && r3.Peak.Y == -2 && r3.Width == 10 && r3.Height == 12;

            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void BuildContainerRect_ShouldReturn_CorrectRectangle()
        {
            MyRectangle r1 = new MyRectangle(10, 10);
            MyRectangle r2 = new MyRectangle(new Point2D(-1, -8), 3, 3);
            MyRectangle r3 = MyRectangle.BuildContainerRect(r1, r2);

            bool isCorrect = r3.Peak.X == -1 && r3.Peak.Y == 0 && r3.Width == 14 && r3.Height == 14;

            Assert.IsTrue(isCorrect);
        }

        [TestMethod]
        public void Intersects_ShouldReturn_True()
        {
            MyRectangle r1 = new MyRectangle(10, 10);
            MyRectangle r2 = new MyRectangle(new Point2D(-1, -2), 13, 13);

            Assert.IsTrue(r1.Intersects(r2));
        }

        [TestMethod]
        public void Intersects_ShouldReturn_False()
        {
            MyRectangle r1 = new MyRectangle(10, 10);
            MyRectangle r2 = new MyRectangle(new Point2D(-1, -8), 3, 3);

            Assert.IsFalse(r1.Intersects(r2));
        }

    }
}
