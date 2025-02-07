using NUnit.Framework;
using System.Collections.Generic;
using testing_lab2;

namespace Testing
{
    public class Tests
    {


        [TestCase("2", "2", "4")]
        [TestCase("1,5", "1,5", "3")]
        [TestCase("1", "2", "3")]
        public void CheckNotTriangle(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (-1, -1), (-1, -1), (-1, -1) };
            var expect = ("íå òðåóãîëüíèê", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }


        [TestCase("1","2","c")]
        [TestCase("5", "6", "0")]
        [TestCase("6", "7", "$")]
        [TestCase("-3,2", "3,2", "3,2")]
        public void CheckInvalidData(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (-2, -2), (-2, -2), (-2, -2) };
            var expect = ("", tuple);


            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckScaleneTriangle()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (39, 0), (33, 47) };
            var expect = ("ðàçíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo("48", "58", "39");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckEquilateralTriangleInteger()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (48, 0), (23, 41) };
            var expect = ("ðàâíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo("48", "48", "48");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("4,5", "4,5", "4,5")]
        [TestCase("4.5", "4.5", "4.5")]
        [TestCase("4,5", "4.5", "4,5")]
        [TestCase("4,5", "4,5", "4.5")]
        [TestCase("4.5", "4,5", "4,5")]
        public void CheckEquilateralTriangleDouble(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (4, 0), (2, 3) };
            var expect = ("ðàâíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckIsoscelesTriangleIntegerSideAB()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (3, 0), (1, 4) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("5", "5", "3");

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckIsoscelesTriangleIntegerSideAC()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (5, 0), (0, 2) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("5", "3", "5");

            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckIsoscelesTriangleIntegerSideBC()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (5, 0), (4, 2) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("3", "5", "5");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("3,5", "5,5", "5,5")]
        [TestCase("3.5", "5.5", "5.5")]
        [TestCase("3,5", "5.5", "5,5")]
        [TestCase("3.5", "5,5", "5,5")]
        [TestCase("3,5", "5,5", "5.5")]
        public void CheckIsoscelesTriangleDoubleSideBC(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (5, 0), (4, 3) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a,b,c);

            Assert.AreEqual(expect, actual);
        }

        [TestCase("5,5", "3,5", "5,5")]
        [TestCase("5.5", "3.5", "5.5")]
        [TestCase("5.5", "3,5", "5,5")]
        [TestCase("5,5", "3.5", "5,5")]
        [TestCase("5,5", "3,5", "5.5")]
        public void CheckIsoscelesTriangleDoubleSideAC(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (5, 0), (1, 3) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a,b,c);

            Assert.AreEqual(expect, actual);
        }
        [TestCase("5,5", "5,5", "3,5")]
        [TestCase("5.5", "5.5", "3.5")]
        [TestCase("5.5", "5,5", "3,5")]
        [TestCase("5,5", "5,5", "3.5")]
        [TestCase("5,5", "5.5", "3,5")]
        public void CheckIsoscelesTriangleDoubleSideAB(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (3, 0), (1, 5) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a,b,c);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckScaleneTriangleInteger()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (90, 0), (100, 91) };
            var expect = ("ðàçíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo("400", "588", "390");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("780,56", "678,78", "670,90")]
        [TestCase("780.56", "678,78", "670,90")]
        [TestCase("780,56", "678.78", "670,90")]
        [TestCase("780,56", "678,78", "670.90")]
        [TestCase("780.56", "678.78", "670.90")]
        public void CheckScaleneTriangleDouble(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (33, 95) };
            var expect = ("ðàçíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckScaledCoordinatesEquilateralTriangle()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (49, 86) };
            var expect = ("ðàâíîñòîðîííèé", tuple);

            var actual = Triangle.GetTriangleInfo("400", "400", "400");

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckScaledCoordinatesIsoscelesTriangleIntegerSideAB()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (50, 83) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("390", "390", "400");

            Assert.AreEqual(expect, actual);
        }


        [TestCase("350,6", "350,6", "234,56")]
        [TestCase("350,6", "350.6", "234,56")]
        [TestCase("350,6", "350,6", "234.56")]
        [TestCase("350.6", "350,6", "234,56")]
        [TestCase("350.6", "350.6", "234.56")]
        public void CheckScaledCoordinatesIsoscelesTriangleDoubleSideAB(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (70, 0), (35, 100) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckScaledCoordinatesIsoscelesTriangleIntegerSideAC()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (52, 87) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("390", "400", "390");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("350,6", "234,56", "350,6")]
        [TestCase("350,6", "234,56", "350.6")]
        [TestCase("350,6", "234.56", "350,6")]
        [TestCase("350.6", "234,56", "350,6")]
        [TestCase("350.6", "234.56", "350.6")]
        public void CheckScaledCoordinatesIsoscelesTriangleDoubleSideAC(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (22, 63) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckScaledCoordinatesIsoscelesTriangleIntegerSideBC()
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (47, 87) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo("400", "390", "390");

            Assert.AreEqual(expect, actual);
        }

        [TestCase("234,56", "350,6", "350,6")]
        [TestCase("234,56", "350,6", "350.6")]
        [TestCase("234,56", "350.6", "350,6")]
        [TestCase("234.56", "350,6", "350,6")]
        [TestCase("234.56", "350.6", "350.6")]
        public void CheckScaledCoordinatesIsoscelesTriangleDoubleSideBC(string a, string b, string c)
        {

            List<(int, int)> tuple = new List<(int, int)>();
            tuple = new List<(int, int)> { (0, 0), (100, 0), (77, 63) };
            var expect = ("ðàâíîáåäðåííûé", tuple);

            var actual = Triangle.GetTriangleInfo(a, b, c);

            Assert.AreEqual(expect, actual);
        }

    }
}
