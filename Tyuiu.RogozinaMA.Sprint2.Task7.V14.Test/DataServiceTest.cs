using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task7.V14.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedAreaInside()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOnBorder()
        {
            DataService ds = new DataService();
            double x = 0.707; // точка на границе окружности и выше линии
            double y = 0.707;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOutsideCircle()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaBelowLine()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.6; // ниже линии y = -x
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOnLine()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.5; // точно на линии y = -x
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true; // по условию "выше или на линии"
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOrigin()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true; // внутри круга и выше линии
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaQuarter()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true; // внутри круга и выше линии
            Assert.AreEqual(wait, res);
        }
    }
}