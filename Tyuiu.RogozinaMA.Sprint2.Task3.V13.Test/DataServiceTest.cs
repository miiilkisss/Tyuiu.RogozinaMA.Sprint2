using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task3.V13.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateForXGreaterThanOne()
        {
            DataService ds = new DataService();
            double x = 2.5;
            double res = ds.Calculate(x);
            // Проверяем что результат округлен до 3 знаков
            Assert.AreEqual(3, res.ToString().Split('.')[1].Length);
        }

        [TestMethod]
        public void ValidCalculateForXEqualsZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            // y = 8*0² - sin(0²) + 12 = 12
            Assert.AreEqual(12.000, res);
        }

        [TestMethod]
        public void ValidCalculateForXBetweenMinus17And2()
        {
            DataService ds = new DataService();
            double x = 1.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(3, res.ToString().Split('.')[1].Length);
        }

        [TestMethod]
        public void ValidCalculateForXLessThanMinus17()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            // y = -20 + 10*(-20) - (1/(-20)) = -20 -200 + 0.05 = -219.95
            Assert.AreEqual(-219.950, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculateForXEqualsOne()
        {
            DataService ds = new DataService();
            double x = 1;
            ds.Calculate(x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculateForXEqualsTwo()
        {
            DataService ds = new DataService();
            double x = 2;
            ds.Calculate(x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculateForXEqualsMinus17()
        {
            DataService ds = new DataService();
            double x = -17;
            ds.Calculate(x);
        }

        [TestMethod]
        public void ValidCalculateRounding()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double res = ds.Calculate(x);
            // Проверяем округление до 3 знаков
            string resString = res.ToString("F6");
            int decimalPlaces = resString.Length - resString.IndexOf('.') - 1;
            Assert.IsTrue(decimalPlaces <= 3);
        }
    }
}