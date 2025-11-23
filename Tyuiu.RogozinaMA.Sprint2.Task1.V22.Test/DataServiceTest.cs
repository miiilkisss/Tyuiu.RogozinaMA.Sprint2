using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task1.V22.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] wait = { true, true, true, false, false, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetLogicOperationsFirstOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(true, res[0]); // (324 < 696) | (254 > 155) → True | True → True
        }

        [TestMethod]
        public void ValidGetLogicOperationsSecondOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(true, res[1]); // (324 == 696) & (254 != 155) → False & True → False
        }

        [TestMethod]
        public void ValidGetLogicOperationsThirdOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(true, res[2]); // (324 <= 696) || (254 >= 155) → True || True → True
        }

        [TestMethod]
        public void ValidGetLogicOperationsFourthOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(false, res[3]); // (324 > 696) && (254 < 155) → False && False → False
        }

        [TestMethod]
        public void ValidGetLogicOperationsFifthOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(false, res[4]); // !(324 != 696) → !True → False
        }

        [TestMethod]
        public void ValidGetLogicOperationsSixthOperation()
        {
            DataService ds = new DataService();
            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual(false, res[5]); // (324 == 696) ^ (254 == 155) → False ^ False → False
        }
    }
}