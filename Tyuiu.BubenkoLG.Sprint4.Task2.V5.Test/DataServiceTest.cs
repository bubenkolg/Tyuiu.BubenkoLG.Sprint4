using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint4.Task2.V5.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };

            int res = ds.Calculate(array);
            int wait = 768;
            Assert.AreEqual(res, wait);

        }
    }
}