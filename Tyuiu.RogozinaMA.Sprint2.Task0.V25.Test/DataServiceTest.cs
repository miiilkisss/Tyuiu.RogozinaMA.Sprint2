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
    }
}