using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task4.V2.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateWhenXGreaterThanYPlus3()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 15.500; // 10 + (10+1)/2 = 10 + 11/2 = 10 + 5.5 = 15.5
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateWhenXLessOrEqualYPlus3()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.469; // ((5+5)/(5+2))^2 = (10/7)^2 ≈ (1.42857)^2 ≈ 2.04082
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateRounding()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 1;
            double res = ds.Calculate(x, y);
            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculateWhenYZeroInFirstCase()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 0;
            ds.Calculate(x, y); // x > y+3 (10 > 3) - будет деление на 0 в первой формуле
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void InvalidCalculateWhenYMinusTwoInSecondCase()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -2;
            ds.Calculate(x, y); // x <= y+3 (1 <= 1) - будет деление на 0 во второй формуле
        }
    }
}
