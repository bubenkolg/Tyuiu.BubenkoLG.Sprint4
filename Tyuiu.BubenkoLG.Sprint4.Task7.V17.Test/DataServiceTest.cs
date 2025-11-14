using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint4.Task7.V17.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string array = "753159864";
            int rows = 3;
            int columns = 3;

            int res = ds.Calculate(rows, columns, array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}