using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task2.V8.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedAreaMainRect()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaTopProtrusion()
        {
            DataService ds = new DataService();
            int x = 7;
            int y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaBottomProtrusion()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaLeftEar()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaRightEar()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOutside()
        {
            DataService ds = new DataService();
            int x = 15;
            int y = 15;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaHole()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.IsFalse(res);
        }
    }
}