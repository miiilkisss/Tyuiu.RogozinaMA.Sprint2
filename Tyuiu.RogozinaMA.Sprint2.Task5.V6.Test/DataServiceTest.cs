using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValueQueenSpades()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 12;
            string wait = "Дама пик";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueSixDiamonds()
        {
            DataService ds = new DataService();
            int m = 3;
            int k = 6;
            string wait = "Шестерка бубен";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueAceHearts()
        {
            DataService ds = new DataService();
            int m = 4;
            int k = 14;
            string wait = "Туз червей";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueJackClubs()
        {
            DataService ds = new DataService();
            int m = 2;
            int k = 11;
            string wait = "Валет треф";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueKingDiamonds()
        {
            DataService ds = new DataService();
            int m = 3;
            int k = 13;
            string wait = "Король бубен";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueNineHearts()
        {
            DataService ds = new DataService();
            int m = 4;
            int k = 9;
            string wait = "Девятка червей";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardNameAndValueWrongSuit()
        {
            DataService ds = new DataService();
            int m = 5;
            int k = 10;
            ds.FindCardNameAndValue(m, k);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardNameAndValueWrongRank()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 5;
            ds.FindCardNameAndValue(m, k);
        }
    }
}