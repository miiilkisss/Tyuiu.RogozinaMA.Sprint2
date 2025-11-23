using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RogozinaMA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValueSix()
        {
            DataService ds = new DataService();
            int value = 6;
            string res = ds.FindCardValue(value);
            string wait = "Шестерка";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueSeven()
        {
            DataService ds = new DataService();
            int value = 7;
            string res = ds.FindCardValue(value);
            string wait = "Семерка";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueEight()
        {
            DataService ds = new DataService();
            int value = 8;
            string res = ds.FindCardValue(value);
            string wait = "Восьмерка";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueNine()
        {
            DataService ds = new DataService();
            int value = 9;
            string res = ds.FindCardValue(value);
            string wait = "Девятка";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueTen()
        {
            DataService ds = new DataService();
            int value = 10;
            string res = ds.FindCardValue(value);
            string wait = "Десятка";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueJack()
        {
            DataService ds = new DataService();
            int value = 11;
            string res = ds.FindCardValue(value);
            string wait = "Валет";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueQueen()
        {
            DataService ds = new DataService();
            int value = 12;
            string res = ds.FindCardValue(value);
            string wait = "Дама";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueKing()
        {
            DataService ds = new DataService();
            int value = 13;
            string res = ds.FindCardValue(value);
            string wait = "Король";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardValueAce()
        {
            DataService ds = new DataService();
            int value = 14;
            string res = ds.FindCardValue(value);
            string wait = "Туз";
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardValueBelowRange()
        {
            DataService ds = new DataService();
            int value = 5;
            ds.FindCardValue(value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardValueAboveRange()
        {
            DataService ds = new DataService();
            int value = 15;
            ds.FindCardValue(value);
        }
    }
}