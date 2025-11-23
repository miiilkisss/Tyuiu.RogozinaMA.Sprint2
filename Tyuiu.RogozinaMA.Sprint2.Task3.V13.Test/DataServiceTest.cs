using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task3.V13.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateForXBetweenMinus17And2()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = -2.594;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateForXGreaterThanOne()
        {
            DataService ds = new DataService();
            double x = 2.5;
            double res = ds.Calculate(x);
            // Ожидаемое значение для x = 2.5
            Assert.AreEqual(3, res.ToString().Split('.')[1].Length); 
        }

        [TestMethod]
        public void ValidCalculateForXEqualsZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 12.000;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateForXLessThanMinus17()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            // Ожидаемое значение для x = -20
            Assert.AreEqual(3, res.ToString().Split('.')[1].Length); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculateForXEqualsOne()
        {
            DataService ds = new DataService();
            double x = 1;
            ds.Calculate(x);
        }
    }
}