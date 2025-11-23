using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task0.V25.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] wait = { true, true, true, false, false, false };
            bool[] res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetCompareOperationsFirstOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(true, res[0]); // x == y + 46 → 205 == 205
        }

        [TestMethod]
        public void ValidGetCompareOperationsSecondOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(true, res[1]); // x != y → 205 != 159
        }

        [TestMethod]
        public void ValidGetCompareOperationsThirdOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(true, res[2]); // x - 100 < y → 105 < 159
        }
         
        [TestMethod]
        public void ValidGetCompareOperationsFourthOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(false, res[3]); // x > y + 50 → 205 > 209
        }

        [TestMethod]
        public void ValidGetCompareOperationsFifthOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(false, res[4]); // x <= y → 205 <= 159
        }

        [TestMethod]
        public void ValidGetCompareOperationsSixthOperation()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = ds.GetCompareOperations(x, y);
            Assert.AreEqual(false, res[5]); // x - 46 >= y + 1 → 159 >= 160
        }
    }
}