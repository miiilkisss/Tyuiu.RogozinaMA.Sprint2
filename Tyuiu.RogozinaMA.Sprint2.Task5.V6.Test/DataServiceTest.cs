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
            string wait = "дама пик";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueSixDiamonds()
        {
            DataService ds = new DataService();
            int m = 3;
            int k = 6;
            string wait = "шестерка бубен";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueAceHearts()
        {
            DataService ds = new DataService();
            int m = 4;
            int k = 14;
            string wait = "туз червей";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueJackClubs()
        {
            DataService ds = new DataService();
            int m = 2;
            int k = 11;
            string wait = "валет треф";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueKingDiamonds()
        {
            DataService ds = new DataService();
            int m = 3;
            int k = 13;
            string wait = "король бубен";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueNineHearts()
        {
            DataService ds = new DataService();
            int m = 4;
            int k = 9;
            string wait = "девятка червей";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueSevenSpades()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 7;
            string wait = "семерка пик";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueEightClubs()
        {
            DataService ds = new DataService();
            int m = 2;
            int k = 8;
            string wait = "восьмерка треф";
            string res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueTenDiamonds()
        {
            DataService ds = new DataService();
            int m = 3;
            int k = 10;
            string wait = "десятка бубен";
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
        public void InvalidFindCardNameAndValueWrongRankLow()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 5;
            ds.FindCardNameAndValue(m, k);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardNameAndValueWrongRankHigh()
        {
            DataService ds = new DataService();
            int m = 1;
            int k = 15;
            ds.FindCardNameAndValue(m, k);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueAllSuitsWithSix()
        {
            DataService ds = new DataService();

            string res1 = ds.FindCardNameAndValue(1, 6);
            Assert.AreEqual("шестерка пик", res1);

            string res2 = ds.FindCardNameAndValue(2, 6);
            Assert.AreEqual("шестерка треф", res2);

            string res3 = ds.FindCardNameAndValue(3, 6);
            Assert.AreEqual("шестерка бубен", res3);

            string res4 = ds.FindCardNameAndValue(4, 6);
            Assert.AreEqual("шестерка червей", res4);
        }

        [TestMethod]
        public void ValidFindCardNameAndValueAllFaceCards()
        {
            DataService ds = new DataService();

            string res1 = ds.FindCardNameAndValue(1, 11);
            Assert.AreEqual("валет пик", res1);

            string res2 = ds.FindCardNameAndValue(1, 12);
            Assert.AreEqual("дама пик", res2);

            string res3 = ds.FindCardNameAndValue(1, 13);
            Assert.AreEqual("король пик", res3);

            string res4 = ds.FindCardNameAndValue(1, 14);
            Assert.AreEqual("туз пик", res4);
        }
    }
} 